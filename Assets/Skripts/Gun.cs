using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;   // Referenz zum Transform, an dem die Kugeln spawnen sollen
    public GameObject bulletPrefab;      // Prefab des Kugelobjekts, das instanziiert wird
    public float bulletSpeed = 10;       // Geschwindigkeit, mit der die Kugel fliegen soll

    void Update()
    {
        // Überprüfen, ob die Leertaste gedrückt wurde
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Kugel-Prefab an der Position und Rotation von bulletSpawnPoint instanziieren
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Zugriff auf das Rigidbody-Komponente der Kugel und Einstellen der Geschwindigkeit, um sie vorwärts zu bewegen
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
