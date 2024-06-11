using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Destroy the bullet on collision with any object
        Destroy(gameObject);
    }
}
