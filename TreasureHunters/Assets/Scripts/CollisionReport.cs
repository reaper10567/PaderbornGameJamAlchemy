using UnityEngine;
using System.Collections;

public class CollisionReport : MonoBehaviour {

    public bool colliding = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        colliding = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        colliding = false;
    }
}
