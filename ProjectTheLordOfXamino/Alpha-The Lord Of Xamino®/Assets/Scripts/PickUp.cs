using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static PickUp pickupInstance;
    
    public bool isCoin, isHeal;

    [SerializeField] AudioSource source;
    [SerializeField] AudioClip coinSound, healSound;
    [SerializeField] bool isCollected;
    public float coinsCollected = 0;


    private void Awake()
    {
        pickupInstance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            

            if (isCoin)
            {
                coinsCollected++;


                UILifeController.instance.UpdateCoinCount();

                isCollected = true;

                AudioSource.PlayClipAtPoint(coinSound, Camera.main.transform.position);

                Destroy(gameObject);

            }

            if (isHeal)
            {
                if(PlayerLife.instance.currerntHealh != PlayerLife.instance.maxHealth)
                {
                    PlayerLife.instance.HealPlayer();

                    isCollected = true;

                    AudioSource.PlayClipAtPoint(healSound, Camera.main.transform.position);



                    Destroy(gameObject);    
                }
            }
        }
    }
}
