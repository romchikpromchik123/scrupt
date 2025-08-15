using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player cocoin = other.GetComponent<Player>();
        cocoin.collectCoins();
        Destroy(gameObject);
    }
}
