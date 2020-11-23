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
        character = FindObjectOfType<AssignPlayers>().AssignRoles(gameObject);
        Debug.Log(character);


        // GameObject GameManager = GameObject.Find("GameManager");

        // GameManager gameManager = GameManager.GetComponent<GameManager>();

        // index = UnityEngine.Random.Range(0,gameManager.characterList.Count-1);

        // Instantiate(gameManager.characterList[index], transform);

        // gameManager.characterList.RemoveAt(index);

        // playerPosition = GameObject.FindGameObjectWithTag("NetworkGamePlayer").transform.position;

        // foreach (GameObject spawnPoint in gameManager.spawnPoints)
        // {
        //     if (spawnPoint.transform.position != playerPosition)
        //     {
        //         Instantiate(gameManager.hiddenPlayer, spawnPoint.transform.position, spawnPoint.transform.rotation);
        //     }
        // }
     }

  
    // [SyncVar]
    // private string displayName = "Loading...";

    // [Server]
    // public void SetDisplayName(string displayName)
    // {

    //     this.displayName = displayName;
        
    // }


}
