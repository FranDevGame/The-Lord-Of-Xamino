using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float velocityMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        rb2D.AddForce(transform.forward * velocityMultiplier);
    }
}
