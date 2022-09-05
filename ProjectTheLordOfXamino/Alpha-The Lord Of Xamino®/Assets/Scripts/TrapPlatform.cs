using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlatform : MonoBehaviour
{

    //[SerializeField] bool isKinematic;
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] GameObject trapPlatform;
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip crashPlatform;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D trapPlatformRb2D = trapPlatform.GetComponent<Rigidbody2D>();
            trapPlatformRb2D.isKinematic = false;

            AudioSource.PlayClipAtPoint(crashPlatform, Camera.main.transform.position);



        }
    }
}
