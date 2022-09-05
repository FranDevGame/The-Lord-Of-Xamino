using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public static KillZone killZoneInstance;

    private void Awake()
    {
        killZoneInstance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerLife.instance.currerntHealh--;

            PrototypeHero.instance.KnocBackPlayer();

            UILifeController.instance.UpdateHealthDisplay();
        }
    }
}
