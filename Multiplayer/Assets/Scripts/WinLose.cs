using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class WinLose : MonoBehaviour
{
    PhotonView view;
    [SerializeField] Canvas WinCanvas;
    [SerializeField] Canvas LoseCanvas;
    private void Awake()
    {
        view = GetComponent<PhotonView>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (view.IsMine)
        {
            Debug.Log("You Win");
            PhotonNetwork.Instantiate(WinCanvas.name, transform.position, Quaternion.identity);
            LoseCanvas.enabled = false;
            Time.timeScale = 0;
        }
        else
        {
            PhotonNetwork.Instantiate(LoseCanvas.name, transform.position, Quaternion.identity);
            WinCanvas.enabled = false;
            Time.timeScale = 0;

        }
    }
}
