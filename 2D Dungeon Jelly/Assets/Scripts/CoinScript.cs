using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject coinParticles;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Instantiate(coinParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void Start(){
        PlayerPrefs.DeleteAll();
    }
}

// public class CoinScript : MonoBehaviour
// {
//     public GameObject coinParticles;
//     string coinID = "";

//     private void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.gameObject.tag == "Player")
//         {
//             Instantiate(coinParticles, transform.position, Quaternion.identity);
//             PlayerPrefs.SetInt(coinID, 1);
//             Destroy(gameObject);
//         }
//     }

//     void Start()
//     {
//         coinID = transform.name;
//         if (PlayerPrefs.GetInt(coinID) == 1)
//         {
//             Destroy(gameObject);
//         }
//     }
// }