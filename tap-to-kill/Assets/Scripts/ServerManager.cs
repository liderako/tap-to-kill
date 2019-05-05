using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ServerManager : Photon.PunBehaviour
{
    [SerializeField]private bool isConnected;
    [SerializeField]private string scene;

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings("");
    }

    public void OnConnectedToMaster()
    {
        isConnected = true;
    }

    public void Update()
    {
        if (isConnected)
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
    }
}
