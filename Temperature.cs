using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Temperature : MonoBehaviour
{
    public Health health;
    public int playerDamage = 2;
    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34f;
    public float freezeSpeed = 0.05f;
    public float freezeDamageTimer = 1f;
    public float freezeDamageDelay = 2f;

    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if (temperatureCurrent <= temperatureCritical)
        {
            if (freezeDamageTimer < 8)
            {
                health.TakeDamage(playerDamage);
                freezeDamageTimer += freezeDamageDelay;
            }
            else
                freezeDamageTimer -= Time.deltaTime;
        }
    }
}