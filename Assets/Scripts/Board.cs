using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Board : MonoBehaviour
{
    private int index; 
    public List<GameObject> characterList = new List<GameObject>();
    public List<GameObject> spawnPoints = new List<GameObject>();
    public GameObject hiddenPlayer;
    private GameObject character; 

    // Start is called before the first frame update
    void Start()
    {

    }

    public void spawnBoard() 
    {
        for (int i = 0; i < 6; i++) 
        {
            index = UnityEngine.Random.Range(0,characterList.Count-1);

            character = Instantiate(characterList[index], spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);

            characterList.RemoveAt(index);

            NetworkServer.Spawn(character);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
