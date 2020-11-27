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
    private GameObject character; 
    

    void Start()

     {

        GameObject SpawnPoints = GameObject.FindWithTag("SpawnPoints");

        GameObject Board = GameObject.FindWithTag("Board");

        Board board = Board.GetComponent<Board>();

        if (isLocalPlayer)

        {
        character = FindObjectOfType<AssignPlayers>().AssignRoles(gameObject);

        playerPosition = character.transform.position;

        FindObjectOfType<HidePlayers>().HideRoles(playerPosition, SpawnPoints, character);
        
        }




     }

  
    // [SyncVar]
    // private string displayName = "Loading...";

    // [Server]
    // public void SetDisplayName(string displayName)
    // {

    //     this.displayName = displayName;
        
    // }


}
