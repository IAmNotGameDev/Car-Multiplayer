using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene("Loading");
    }


    public void quit()
    {
        Application.Quit();
    }

    public void CreateRoom()
    {
        SceneManager.LoadScene("Create");
    }

    public void JoinRoom()
    {
        SceneManager.LoadScene("Join");
    }
}
