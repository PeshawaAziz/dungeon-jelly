using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestart : MonoBehaviour
{
    private float restartDelay = 1f;
    private string currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        WaitAndRestartScene();
        Destroy(gameObject, 1f);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void WaitAndRestartScene(){
        Invoke("RestartScene", restartDelay);
    }
}
