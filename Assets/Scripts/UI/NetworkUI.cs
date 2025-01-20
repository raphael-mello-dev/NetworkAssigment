using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkUI : MonoBehaviour
{
    [SerializeField] private GameObject hostButton;
    [SerializeField] private GameObject clientButton;
    [SerializeField] private Button host;
    [SerializeField] private Button client;
    
    void Start()
    {
        host.onClick.AddListener(OnClickHost);
        client.onClick.AddListener(OnClickJoin);
    }

    void OnClickHost()
    {
        NetworkManager.Singleton.StartHost();
        hostButton.SetActive(false);
        clientButton.SetActive(false);
    }

    void OnClickJoin()
    {
        NetworkManager.Singleton.StartClient();
        hostButton.SetActive(false);
        clientButton.SetActive(false);
    }
}