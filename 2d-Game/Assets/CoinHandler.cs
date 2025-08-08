using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        ScoreManager.AddPoints(1);
        Destroy(gameObject);
    }
}
