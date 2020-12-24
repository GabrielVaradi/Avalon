using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class JoinLobbyMenu : MonoBehaviour
{
    [SerializeField] private NetworkRoomManagerAvalon networkManager = null;

    [Header("UI")]
    [SerializeField] private TMP_InputField ipAddressInputField = null;
    [SerializeField] private Button joinButton;

    // Calling this to join the lobby
    public void JoinLobby()    
    {
        string ipAddress = ipAddressInputField.text;

        networkManager.networkAddress = ipAddress;
        networkManager.StartClient();
        
    }
}
