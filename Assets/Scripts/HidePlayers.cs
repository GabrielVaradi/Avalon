using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayers : MonoBehaviour
{

    public GameObject hiddenPlayer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideRoles(Vector3 playerPosition, GameObject SpawnPoints, GameObject character)
    {
        Debug.Log(character.name);
        if (character.name == "WinduGO(Clone)" || character.name == "QuiGonGO(Clone)")
        {
            foreach (Transform spawnPoint in SpawnPoints.transform)
            {
                if (spawnPoint.transform.position != playerPosition)
                {
                    Instantiate(hiddenPlayer, new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, -1), spawnPoint.transform.rotation);
                }
            }
        }
    }
}
