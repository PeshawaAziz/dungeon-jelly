using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NextSceneLoader : MonoBehaviour
{
    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene("Level0" + nextLevel.ToString());
        }
    }
}
