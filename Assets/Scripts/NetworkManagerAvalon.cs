using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Mirror; 
using System;
using System.Linq;

public class NetworkManagerAvalon : NetworkManager
{
    [SerializeField] private int minPlayers = 2;
    
    [Header("Room")]
    [SerializeField] private NetworkRoomPlayerAvalon roomPlayerPrefab = null;
    public static event Action OnClientConnected;
    public static event Action OnClientDisconnected;

    [Header("Game")]
    [SerializeField] private NetworkGamePlayerAvalon gamePlayerPrefab = null;
    // [SerializeField] private GameObject playerSpawnSystem = null;
    // [SerializeField] private GameObject roundSystem = null;

    public List<NetworkRoomPlayerAvalon> RoomPlayers { get; } = new List<NetworkRoomPlayerAvalon>();
    public List<NetworkGamePlayerAvalon> GamePlayers { get; } = new List<NetworkGamePlayerAvalon>();


    public override void OnStartServer() => spawnPrefabs = Resources.LoadAll<GameObject>("SpawnablePrefabs").ToList();
    
    public override void OnStartClient()
    {
        var spawnablePrefabs = Resources.LoadAll<GameObject>("SpawnablePrefabs");
        foreach (var prefab in spawnablePrefabs)
        {
            ClientScene.RegisterPrefab(prefab);
        }
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
        OnClientConnected?.Invoke();
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        base.OnClientDisconnect(conn);
        OnClientDisconnected?.Invoke();
    }
    public override void OnServerConnect(NetworkConnection conn)
    {
        if (numPlayers >= maxConnections)
        {
            conn.Disconnect();
            return;
        }
        if (SceneManager.GetActiveScene().name != "Lobby")
        {
            conn.Disconnect();
            return;
        }
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        if (conn.identity != null)
        {
            var player = conn.identity.GetComponent<NetworkRoomPlayerAvalon>();
            
            RoomPlayers.Remove(player);

            NotifyPlayersOfReadyState();
        }

        base.OnServerDisconnect(conn);
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        if (SceneManager.GetActiveScene().name == "Lobby")
        {
            bool isLeader = RoomPlayers.Count == 0;

            NetworkRoomPlayerAvalon roomPlayerInstance = Instantiate(roomPlayerPrefab);

            roomPlayerInstance.IsLeader = isLeader;

            NetworkServer.AddPlayerForConnection(conn, roomPlayerInstance.gameObject);
        }
    }

    public override void OnStopServer()
    {
        RoomPlayers.Clear();
    }

    private bool IsReadyToStart()
    {
        if (numPlayers < minPlayers) { return false; }

        foreach (var player in RoomPlayers)
        {
            if (!player.IsReady) { return false; }
        }

        return true;
    }

    public void NotifyPlayersOfReadyState()
    {
        foreach (var player in RoomPlayers)
        {
            player.HandleReadyToStart(IsReadyToStart());
        }
    }

    public void StartGame()
    {
        if(SceneManager.GetActiveScene().name == "Lobby")
        {
            if (!IsReadyToStart()) { return ; }

            ServerChangeScene("Game");

        }
    }

    public override void ServerChangeScene(string newSceneName)
    {
        // From menu to game
        if (SceneManager.GetActiveScene().name == "Lobby" && newSceneName.StartsWith("Game"))
        {
            for (int i = RoomPlayers.Count - 1; i >= 0; i--)
            {
                var conn = RoomPlayers[i].connectionToClient;
                var gameplayerInstance = Instantiate(gamePlayerPrefab);
                gameplayerInstance.SetDisplayName(RoomPlayers[i].DisplayName);

                NetworkServer.ReplacePlayerForConnection(conn, gameplayerInstance.gameObject, true); 
            }
        }

        base.ServerChangeScene(newSceneName);
    }
}
