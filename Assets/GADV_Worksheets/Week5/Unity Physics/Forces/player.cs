using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    CharacterController controller;
    // Your variables used for moving the player
    public float speed = 6.0f;
    public float rotateSpeed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;
    private int jumps;

    // Code to set the radius and force of the explosion
    public float radius = 5.0F;
    public float power = 10000.0F;

    // Kick (ChatGPT)
    public float kickStrength = 10000.0F;

    void Start()
    {
        CheckLineOfSight();
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false; // See comment about this!
    }
    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Your code to generate the explosion (ChatGPT)
            // Create a position for the explosion at the player's position
            Vector3 explosionPosition = transform.position;

            // Get all colliders within the radius
            Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);

            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    // Apply explosion force
                    rb.AddExplosionForce(power, explosionPosition, radius);
                }
            }
        }
    }

    void Kick() 
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * kickStrength);
            }
        }
    }

    void CheckLineOfSight()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        RaycastHit hit;

        foreach (GameObject enemy in enemies)
        {
            Vector3 direction = enemy.transform.position - transform.position;
            Debug.DrawRay(transform.position, direction, Color.red);

            if (Physics.Raycast(transform.position, direction, out hit, 30f))
            {
                if (hit.collider.gameObject == enemy)
                {
                    enemy.GetComponent<Renderer>().material.color = Color.green;
                }
            }
        }
    }

    void FixedUpdate()
    {
        Kick();
        CheckExplosion();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButtonDown("Fire1"))
            {
                moveDirection.y = jumpSpeed;
            }
            jumps = 0;
        }
        else
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), moveDirection.y, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection.x *= speed;
            moveDirection.z *= speed;
            if (Input.GetButtonDown("Fire1") && jumps < 1)
            {
                moveDirection.y = jumpSpeed;
                jumps++;
            }
        }

        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
