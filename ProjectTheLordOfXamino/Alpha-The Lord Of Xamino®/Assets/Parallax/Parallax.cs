using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Vector2 movementVelocity;

    [SerializeField] Vector2 offset;

    [SerializeField] Material material;

    [SerializeField] Rigidbody2D rb2D;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
        rb2D = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = (rb2D.velocity.x * 0.1f) * movementVelocity * Time.deltaTime;

        material.mainTextureOffset += offset;
    }
}
