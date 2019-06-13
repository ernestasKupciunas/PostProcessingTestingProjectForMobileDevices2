using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneConfig : MonoBehaviour
{
    public void PlayAgainGameScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void QuitTheApp()
    {
        Application.Quit();
    }
}
