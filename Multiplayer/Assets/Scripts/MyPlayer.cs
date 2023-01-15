using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class MyPlayer : MonoBehaviour
{
    public GameObject myPlayerAvatar;

    Photon.Realtime.Player[] allPlayers;
    int myNumberInRoom;
    void Start()
    {
        allPlayers = PhotonNetwork.PlayerList;

        foreach(Photon.Realtime.Player player in allPlayers)
        {
            if (player!= PhotonNetwork.LocalPlayer) {
            myNumberInRoom++;
            }
        }

            PhotonNetwork.Instantiate(myPlayerAvatar.name, NewSpawnSystem.instance.spawnpoints[myNumberInRoom].position, Quaternion.identity);

    }


}
