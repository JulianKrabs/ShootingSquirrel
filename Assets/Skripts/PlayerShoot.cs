using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; // Referenz zum Projektil
    public Transform shootPoint;        // Punkt, von dem aus das Projektil geschossen wird
    public float projectileSpeed = 10f;

    void Update()
    {
        // Pr�ft, ob die Schusstaste (linke Maustaste) gedr�ckt wurde
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Erstellt das Projektil an der Schusspunktposition
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        // F�ge dem Projektil eine Vorw�rtsbewegung hinzu
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = shootPoint.forward * projectileSpeed;
        }
    }
}
