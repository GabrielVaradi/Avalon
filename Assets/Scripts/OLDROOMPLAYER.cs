// using Mirror;
// using TMPro;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class OLDROOMPLAYER : NetworkBehaviour
// {
//     [Header("UI")]
//     [SerializeField] private GameObject lobbyUI = null;
//     [SerializeField] private TMP_Text[] playerNameTexts = new TMP_Text[6];
//     [SerializeField] private TMP_Text[] playerReadyTexts = new TMP_Text[6];
//     [SerializeField] private Button startGameButton = null;

//     [SyncVar(hook = nameof(HandleDisplayNameChanged))]
//     public string DisplayName = "Loading...";
//     [SyncVar(hook = nameof(HandleReadyStatusChanged))]
//     public bool IsReady = false;

//     private bool isLeader;
//     public bool IsLeader
//     {
//         set
//         {
//             isLeader = value;
//             startGameButton.gameObject.SetActive(value);
//         }
//     }

//     private NetworkManagerAvalon room;
//     private NetworkManagerAvalon Room
//     {
//         get
//         {
//             if (room != null) { return room; }
//             return room = NetworkManager.singleton as NetworkManagerAvalon;
//         }
//     }


//     public override void OnStartClient()
//     {
//         Room.RoomPlayers.Add(this);

//         UpdateDisplay();
//     }

//     public override void OnStopClient()
//     {
        
//         Room.RoomPlayers.Remove(this);
//         Destroy(room);
//         UpdateDisplay();
        
//     }

//     public void LeaveLobby()
//     {

//         room.StopHost();
//         Destroy(room);
        
//     }


//     public void HandleReadyToStart(bool readyToStart)
//     {
//         if (!isLeader) { return; }

//         startGameButton.interactable = readyToStart;
//     }

//     [Command]
//     private void CmdSetDisplayName(string displayName)
//     {
//         DisplayName = displayName;
//     }

//     [Command]
//     public void CmdReadyUp()
//     {
//         IsReady = !IsReady;

//         Room.NotifyPlayersOfReadyState();
//     }

//     [Command]
//     public void CmdStartGame()
//     {
//         if (Room.RoomPlayers[0].connectionToClient != connectionToClient) { return; }

//         Room.StartGame();
//     }
// }
