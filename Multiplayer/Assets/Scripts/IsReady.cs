using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class IsReady : MonoBehaviour
{
    [SerializeField] Canvas disableControl;

    PhotonView view;

    private void Awake()
    {
        view = GetComponent<PhotonView>();
    }
    public void Start()
    {

        if (PhotonNetwork.PlayerList.Length == 1)
        {
            PhotonNetwork.Instantiate(disableControl.name, transform.position, Quaternion.identity);
            disableControl.enabled = true;
        }
        }
    public void Update()
    {

        if (PhotonNetwork.PlayerList.Length == 2)
        {
            disableControl.enabled = false;
            if (view.IsMine)
            {
                disableControl.enabled = false;
            }
        }



    }
}
