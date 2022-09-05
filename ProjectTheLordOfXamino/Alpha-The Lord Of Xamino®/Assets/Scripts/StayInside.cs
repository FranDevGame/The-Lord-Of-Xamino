using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.76f, 8.62f), Mathf.Clamp(transform.position.y, -4.80f, 4.86f), transform.position.z);
    }
}
