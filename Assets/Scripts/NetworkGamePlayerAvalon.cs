using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
 

public class NetworkGamePlayerAvalon : NetworkBehaviour
{

    private int index; 
    public Vector3 playerPosition;
    private Vector3 senatePosition;
    private GameObject character;
    private GameObject[] players;
    [SerializeField] private Button sendOnMission = null;
    
    void Start()
    {
       Invoke("StartGame", 2);
    }

     void StartGame()
     {
       GameObject SpawnPoints = GameObject.FindWithTag("SpawnPoints");
        senatePosition = FindObjectOfType<Board>().senatePosition;

        if (isLocalPlayer)

        {

          character = FindObjectOfType<AssignPlayers>().AssignRoles(gameObject);

          playerPosition = character.transform.position;

          FindObjectOfType<HidePlayers>().HideRoles(playerPosition, SpawnPoints, character);

          // playerPosition = senatePosition;
          // Debug.Log(playerPosition.x);
          // Debug.Log(senatePosition.x);

          // Debug.Log(playerPosition.y);
          // Debug.Log(senatePosition.y);

          // Debug.Log(senatePosition.x == playerPosition.x);
          // Debug.Log(senatePosition.y == playerPosition.y + 1);
          // Debug.Log(senatePosition.x == playerPosition.x && senatePosition.y == playerPosition.y + 1);

          // if (senatePosition.x == playerPosition.x && senatePosition.y == playerPosition.y + 1)
          if (isServer)
          {
            showSenateOptions();

          }

        }
        
     }

     void Update()
     {
       players = GameObject.FindGameObjectsWithTag("NetworkGamePlayer");
     }
     
     public void showSenateOptions()
     {
       Debug.Log(players.Length);
       sendOnMission.gameObject.SetActive(true);
     }


  
    // [SyncVar]
    // private string displayName = "Loading...";

    // [Server]
    // public void SetDisplayName(string displayName)
    // {

    //     this.displayName = displayName;
        
    // }


}
