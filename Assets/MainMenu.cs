using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void PlayAR()
    {
        SceneManager.LoadScene(1);
     
    }

    public void Tentang()
    {
        SceneManager.LoadScene(3);
    }

    public void Bantuan()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitAR()
    {
        Application.Quit();
    }
}
