using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private int coin = 0;

    public TextMeshProUGUI txtCoins;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Coin"){
            coin++;
            txtCoins.text = coin.ToString();
        }
    }
}
