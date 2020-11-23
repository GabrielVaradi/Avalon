using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignPlayers : MonoBehaviour
{

    private GameObject character;
    // private List<string> characters = new List<string>() { "Obiwan", "Yoda", "Windu", "Quigon", "Palpatine", "Vader" };
    private List<string> characters = new List<string>() { "Obiwan", "Yoda" };
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
        index = UnityEngine.Random.Range(0,characters.Count-1);
        randomCharacter = characters[index];
        
        character = GameObject.FindWithTag(randomCharacter);
        characters.RemoveAt(index);
        return character;   

    }

}
