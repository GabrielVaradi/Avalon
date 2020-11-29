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
    [SerializeField] private Button sendOnMission = null;
    

    void Start()

     {

        GameObject SpawnPoints = GameObject.FindWithTag("SpawnPoints");
        senatePosition = FindObjectOfType<Board>().senatePosition;

        if (isLocalPlayer)

        {

            character = FindObjectOfType<AssignPlayers>().AssignRoles(gameObject);

            playerPosition = character.transform.position;

            FindObjectOfType<HidePlayers>().HideRoles(playerPosition, SpawnPoints, character);


            Debug.Log("player " + playerPosition);
            Debug.Log("senate " + senatePosition);

            // playerPosition = senatePosition;

            // if (senatePosition.x == playerPosition.x && senatePosition.y == playerPosition.y/* + 1*/)
            // {
              showSenateOptions();
            // }


        }

     }

     public void showSenateOptions()
     {
        Debug.Log("test");
     }

  
    // [SyncVar]
    // private string displayName = "Loading...";

    // [Server]
    // public void SetDisplayName(string displayName)
    // {

    //     this.displayName = displayName;
        
    // }


}
