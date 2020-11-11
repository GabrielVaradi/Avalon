using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NetworkGamePlayerAvalon : NetworkBehaviour
{
  
    [SyncVar]
    private string displayName = "Loading...";

    // private NetworkManagerAvalon room;
    // private NetworkManagerAvalon Room
    // {
    //     get
    //     {
    //         if (room != null) { return room; }
    //         return room = NetworkManager.singleton as NetworkManagerAvalon;
    //     }
    // }

    // public override void OnStartClient()
    // {
    //     DontDestroyOnLoad(gameObject);
    //     Room.GamePlayers.Add(this);

    // }

    // public override void OnStopClient()
    // {
        
    //     Room.GamePlayers.Remove(this);

    // }

    [Server]
    public void SetDisplayName(string displayName)
    {
        this.displayName = displayName;
    }
}
