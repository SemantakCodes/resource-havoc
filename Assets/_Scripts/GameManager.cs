using UnityEngine;
using Unity.Netcode;

public class GameManager : NetworkBehaviour
{
    [SerializeField] private MultiplayerUI multiplayerUI;

    private void Start()
    {
        if(multiplayerUI != null)
        {
            multiplayerUI.OnStartHost += StartHost;
            multiplayerUI.OnStartClient += StartClient;
            multiplayerUI.OnDiconnectClient += DisconnectClient;     
        }
    }

    private void DisconnectClient()
    {
        multiplayerUI.EnableButtons();
        NetworkManager.Shutdown();
    }
    private void StartClient()
    {
        multiplayerUI.DisableButtons();
        NetworkManager.StartClient();
    }
    private void StartHost()
    {
        multiplayerUI.DisableButtons();
        NetworkManager.StartHost();
    }

}
