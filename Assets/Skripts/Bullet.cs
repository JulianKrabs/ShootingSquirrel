using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3; // Lebensdauer

    void Awake()
    {
        Destroy(gameObject, life); // Nach der zeit Zerstört es sich
    }

    void OnCollisionEnter(Collision collision)  // Wenn die Kugel mit einem anderen Collider kollidiert
    {
        Destroy(GameObject.FindWithTag("Enemy")); // Zerstöre das GameObject, mit dem die Kugel kollidiert ist\
        Destroy(GameObject.FindWithTag("Enemy02"));
        Destroy(GameObject.FindWithTag("Enemy03"));
        Destroy(GameObject.FindWithTag("Enemy04"));
        Destroy(GameObject.FindWithTag("Enemy05"));
        Destroy(GameObject.FindWithTag("Enemy06"));
        Destroy(GameObject.FindWithTag("Enemy07"));
        Destroy(GameObject.FindWithTag("Enemy08"));
        Destroy(GameObject.FindWithTag("Enemy09"));
        Destroy(GameObject.FindWithTag("Enemy10"));
        Destroy(gameObject);  // Zerstöre auch die Kugel selbst (dieses GameObject)
    }
}
