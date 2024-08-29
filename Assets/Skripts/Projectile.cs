using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime = 5f; // Projektil zerstören nach einer bestimmten Zeit

    void Start()
    {
        // Zerstört das Projektil nach der angegebenen Zeit
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Überprüfe, ob das Projektil mit einem Feind kollidiert
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Zerstört den Feind
            Destroy(gameObject);           // Zerstört das Projektil
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject); // Zerstört das Projektil, wenn es auf eine Wand trifft
        }
    }
}
