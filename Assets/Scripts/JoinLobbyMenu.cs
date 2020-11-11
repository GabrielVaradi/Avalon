using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class JoinLobbyMenu : MonoBehaviour
{
    [SerializeField] private NetworkRoomManagerAvalon networkManager = null;

    [Header("UI")]
    // [SerializeField] private GameObject landingPagePanel = null;
    [SerializeField] private TMP_InputField ipAddressInputField = null;
    [SerializeField] private Button joinButton;

    // private void OnEnable()
    // {
    //     NetworkRoomManagerAvalon.OnClientConnected += HandleClientConnected;
    //     NetworkRoomManagerAvalon.OnClientDisconnected += HandleClientDisconnected;
    // }

    // private void OnDisable()
    // {
    //     NetworkRoomManagerAvalon.OnClientConnected -= HandleClientConnected;
    //     NetworkRoomManagerAvalon.OnClientDisconnected -= HandleClientDisconnected;
    // }

    public void JoinLobby()
    {
        string ipAddress = ipAddressInputField.text;

        networkManager.networkAddress = ipAddress;
        networkManager.StartClient();

        // joinButton.interactable = false;
    }

    // private void HandleClientConnected()
    // {
    //     joinButton.interactable = true;

    //     gameObject.SetActive(false);
    //     landingPagePanel.SetActive(false);
    // }

    // private void HandleClientDisconnected()
    // {
    //     joinButton.interactable = true;
    // }
}
