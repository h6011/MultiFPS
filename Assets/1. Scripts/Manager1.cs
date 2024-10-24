using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Manager1 : MonoBehaviourPunCallbacks
{

    private void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Try Connect Game");
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster");


        PhotonNetwork.JoinLobby();

    }

    public override void OnJoinedLobby()
    {

        Debug.Log("OnJoinedLobby");

    }




}
