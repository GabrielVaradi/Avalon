using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Board : NetworkBehaviour
{
    private int index;
    public List<GameObject> characterList = new List<GameObject>();
    public List<GameObject> spawnPoints = new List<GameObject>();
    private GameObject character;
    public GameObject Senate; 
    public GameObject senate = null; 

    [SyncVar]
    public Vector3 senatePosition;

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
            senate = Instantiate(Senate, new Vector3(spawnPoints[UnityEngine.Random.Range(0,5)].transform.position.x, spawnPoints[UnityEngine.Random.Range(0,5)].transform.position.y + 1, spawnPoints[UnityEngine.Random.Range(0,5)].transform.position.z), spawnPoints[UnityEngine.Random.Range(0,5)].transform.rotation);
            senatePosition = senate.transform.position;
            NetworkServer.Spawn(senate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
