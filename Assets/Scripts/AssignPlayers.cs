using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class AssignPlayers : NetworkBehaviour
{

    private GameObject character;
    [SyncVar]
    private List<string> characters = new List<string>() { "Obiwan", "Yoda", "Windu", "QuiGon", "Palpatine", "Vader" };
    // private List<string> characters = new List<string>() { "Obiwan", "Obiwan" };
    private string randomCharacter;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject AssignRoles(GameObject player) 
    
    {
        Debug.Log(characters.Count + " before");
        index = UnityEngine.Random.Range(0,characters.Count-1);
        randomCharacter = characters[index];
        
        character = GameObject.FindWithTag(randomCharacter);
        characters.RemoveAt(index);
        Debug.Log(characters.Count + " after");
        return character;   

    }

}
