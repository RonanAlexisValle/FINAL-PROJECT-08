using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sustenance : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerManager.numberofcoins += 1;
            Debug.Log("Coins: " + PlayerManager.numberofcoins);
            Destroy(gameObject);
        }
    }
}

