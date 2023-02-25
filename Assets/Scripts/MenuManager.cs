using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Awake()
    {
        // dont destroy this object
        DontDestroyOnLoad(this.gameObject);
    }


    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void toggleMute(){
        AudioListener.pause = !AudioListener.pause;
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Keluar dari game");
    }
}
