using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public GameObject player;
    // private GameObject clonePlayer;
    private GameObject currentFrame;
    private GameObject nextFrame;
    [SerializeField] private NetworkManagerAvalon networkManager = null;
    [Header("UI")]
    [SerializeField] private GameObject landingPagePanel = null;

    // void OnEnable()
    // {
    //     SceneManager.sceneLoaded += OnLevelFinishedLoading;
    // }

    // void OnDisable()
    // {
    //     SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    // }

    // void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    // {
    //     if (scene.buildIndex == 1)
    //     {
    //          clonePlayer = Instantiate(player, new Vector3(0f, 12.5f, 0f), Quaternion.identity) as GameObject;
    //     }
    // }


    public void PlayGame() 
    {
        // FindObjectOfType<AudioManager>().IsPlaying("Theme");
        FindObjectOfType<LevelLoader>().LoadNextScene("Game");
    }

    public void Retry()
    {
        // Destroy(clonePlayer);
        // FindObjectOfType<LevelLoader>().LoadNextScene("Game");
        // clonePlayer = Instantiate(player, new Vector3(0f, 12.5f, 0f), Quaternion.identity) as GameObject;
    }

    public void GoToMenu()
    {
        FindObjectOfType<LevelLoader>().LoadNextScene("Menu");
    }

    public void GameOver(GameObject currentFrame, GameObject nextFrame)
    {
        // currentFrame = currentFrame;
        // nextFrame = nextFrame;
        // if (currentFrame.active == true)
        //         {
        //             currentFrame.SetActive(false);
        //             nextFrame.SetActive(true);
        //             Destroy(clonePlayer);
        //         }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void WinGame(GameObject currentFrame, GameObject nextFrame)
    {
        // currentFrame = currentFrame;
        // nextFrame = nextFrame;
        // if (currentFrame.active == true)
        //         {
        //             currentFrame.SetActive(false);
        //             nextFrame.SetActive(true);
        //             Destroy(clonePlayer);
        //         }
    }

    public void HostLobby()
    {
        networkManager.StartHost();
        landingPagePanel.SetActive(false);
    }
}
