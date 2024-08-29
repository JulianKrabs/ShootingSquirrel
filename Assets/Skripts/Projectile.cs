using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime = 5f; // Projektil zerst�ren nach einer bestimmten Zeit

    void Start()
    {
        // Zerst�rt das Projektil nach der angegebenen Zeit
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // �berpr�fe, ob das Projektil mit einem Feind kollidiert
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Zerst�rt den Feind
            Destroy(gameObject);           // Zerst�rt das Projektil
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject); // Zerst�rt das Projektil, wenn es auf eine Wand trifft
        }
    }
}
