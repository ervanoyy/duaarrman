using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour {

    public void PlayAgain()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}
