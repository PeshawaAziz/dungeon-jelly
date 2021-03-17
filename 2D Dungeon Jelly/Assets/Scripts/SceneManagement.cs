using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    string currentScene;

    void Start() {
        currentScene = SceneManager.GetActiveScene().name;
    }

    void Update() {
        if(Input.GetButtonDown("Reset")){
            RestartScene();
        }
    }

    public void RestartScene(){
        SceneManager.LoadScene(currentScene);
    }
}
