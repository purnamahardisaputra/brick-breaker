using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Awake() {
        if(gameObject.name == "MenuManager")
            DontDestroyOnLoad(gameObject);
    }


    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
