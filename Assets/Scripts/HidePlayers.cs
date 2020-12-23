using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlayers : MonoBehaviour
{
    public GameObject hiddenPlayer;
    public GameObject yodaOrVader;
    public GameObject evilAlly;
    private GameObject Obiwan;
    private GameObject QuiGon;
    private GameObject Yoda;
    private GameObject Windu;
    private GameObject Palpatine;
    private GameObject Vader;

    // Hide other players to the local player
    public void HideRoles(Vector3 playerPosition, GameObject SpawnPoints, GameObject character)
    {
        Obiwan = GameObject.FindWithTag("Obiwan");
        QuiGon = GameObject.FindWithTag("QuiGon");
        Yoda = GameObject.FindWithTag("Yoda");
        Windu = GameObject.FindWithTag("Windu");
        Palpatine = GameObject.FindWithTag("Palpatine");
        Vader = GameObject.FindWithTag("Vader");
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

        if (character.name == "PalpatineGO(Clone)")
        {

            Instantiate(hiddenPlayer, new Vector3(Yoda.transform.position.x, Yoda.transform.position.y, -1), Yoda.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Obiwan.transform.position.x, Obiwan.transform.position.y, -1), Obiwan.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Windu.transform.position.x, Windu.transform.position.y, -1), Windu.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(QuiGon.transform.position.x, QuiGon.transform.position.y, -1), QuiGon.transform.rotation);
            Instantiate(evilAlly, new Vector3(Vader.transform.position.x, Vader.transform.position.y, -1), Vader.transform.rotation);

        }

        if (character.name == "VaderGO(Clone)")
        {

            Instantiate(hiddenPlayer, new Vector3(Yoda.transform.position.x, Yoda.transform.position.y, -1), Yoda.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Obiwan.transform.position.x, Obiwan.transform.position.y, -1), Obiwan.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Windu.transform.position.x, Windu.transform.position.y, -1), Windu.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(QuiGon.transform.position.x, QuiGon.transform.position.y, -1), QuiGon.transform.rotation);
            Instantiate(evilAlly, new Vector3(Palpatine.transform.position.x, Palpatine.transform.position.y, -1), Palpatine.transform.rotation);

        }

        if (character.name == "YodaGO(Clone)")
        {

            Instantiate(hiddenPlayer, new Vector3(Palpatine.transform.position.x, Palpatine.transform.position.y, -1), Palpatine.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Obiwan.transform.position.x, Obiwan.transform.position.y, -1), Obiwan.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Windu.transform.position.x, Windu.transform.position.y, -1), Windu.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(QuiGon.transform.position.x, QuiGon.transform.position.y, -1), QuiGon.transform.rotation);
            Instantiate(evilAlly, new Vector3(Vader.transform.position.x, Vader.transform.position.y, -1), Vader.transform.rotation);

        }

        if (character.name == "ObiWanGO(Clone)")
        {

            Instantiate(hiddenPlayer, new Vector3(Palpatine.transform.position.x, Palpatine.transform.position.y, -1), Palpatine.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(Windu.transform.position.x, Windu.transform.position.y, -1), Windu.transform.rotation);
            Instantiate(hiddenPlayer, new Vector3(QuiGon.transform.position.x, QuiGon.transform.position.y, -1), QuiGon.transform.rotation);
            Instantiate(yodaOrVader, new Vector3(Yoda.transform.position.x, Yoda.transform.position.y, -1), Yoda.transform.rotation);
            Instantiate(yodaOrVader, new Vector3(Vader.transform.position.x, Vader.transform.position.y, -1), Vader.transform.rotation);

        }
    }
}
