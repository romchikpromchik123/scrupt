using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Missile : MonoBehaviour
{
    public float speed = 2.5f;
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Destroy(gameObject, 3);
    }
    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
    }
}