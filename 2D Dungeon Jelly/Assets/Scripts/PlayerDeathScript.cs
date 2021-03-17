using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathScript : MonoBehaviour
{
    public GameObject deathParticles;
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Spike"){
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }
}
