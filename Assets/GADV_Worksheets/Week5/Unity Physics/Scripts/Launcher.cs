using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float force = 20f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(
            projectilePrefab,
            firePoint.position,
            Quaternion.identity);
            Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * force);
        }
    }
}
