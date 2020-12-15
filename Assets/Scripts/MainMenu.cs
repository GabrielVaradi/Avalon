using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private GameObject currentFrame;
    private GameObject nextFrame;
    [SerializeField] private NetworkRoomManagerAvalon networkManager = null;
    [Header("UI")]
    [SerializeField] private GameObject landingPagePanel = null;

    public void PlayGame() 
    {
        // FindObjectOfType<AudioManager>().IsPlaying("Theme");
        FindObjectOfType<LevelLoader>().LoadNextScene("Game");
    }

    public void Retry() {}

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

    // Host the lobby when clicking on create game
    public void HostLobby()
    {
        networkManager.StartHost();
        landingPagePanel.SetActive(false);
    }
}
