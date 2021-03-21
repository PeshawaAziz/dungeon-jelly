using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathScript : MonoBehaviour
{
    public GameObject deathParticles;
    public GameObject sceneRestart;

    private float timeElapsed;
    private string currentScene;

    void Update(){
        timeElapsed += Time.deltaTime;
    }
    
    void Start(){
        currentScene = SceneManager.GetActiveScene().name;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Spike")
        {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Instantiate(sceneRestart, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}