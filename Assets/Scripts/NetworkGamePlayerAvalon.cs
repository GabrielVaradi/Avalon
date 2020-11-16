using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
 


public class NetworkGamePlayerAvalon : NetworkBehaviour
{

    private int index; 


    void Start()
     {

        GameObject GameManager = GameObject.Find("GameManager");
        GameManager gameManager = GameManager.GetComponent<GameManager>();
        index = UnityEngine.Random.Range(0,gameManager.characterList.Count-1);
        Instantiate(gameManager.characterList[index], transform);
        gameManager.characterList.RemoveAt(index);
        Debug.Log(gameManager.characterList);

     }

  
    [SyncVar]
    private string displayName = "Loading...";

    [Server]
    public void SetDisplayName(string displayName)
    {
        this.displayName = displayName;
    }


}
