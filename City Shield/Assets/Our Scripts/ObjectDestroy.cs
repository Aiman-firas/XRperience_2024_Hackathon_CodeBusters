using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the same tag or any specific condition
        if (collision.gameObject.CompareTag("Destroyable"))
        {
            // Destroy both the current object and the collided object
            Destroy(collision.gameObject); // Destroy the other object
            Destroy(gameObject); // Destroy this object
        }
    }
}
