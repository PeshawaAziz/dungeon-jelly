using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coinParticles;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            Instantiate(coinParticles, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.05f);
        }
    }
}
