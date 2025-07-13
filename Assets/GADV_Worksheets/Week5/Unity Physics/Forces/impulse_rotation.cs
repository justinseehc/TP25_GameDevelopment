using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impulseRotation : MonoBehaviour
{
    public float impulseForce = 10f; // Set this value in Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // NOTE: ForceMode is used to determine how the force is applied (Impulse is instant)
    // X (1,0,0) using Vector3.right / Z (0,0,1) using Vector3.forward
    // Help from ChatGPT
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.AddTorque(Vector3.up * impulseForce, ForceMode.Impulse); //Vector3.up is to control the y-axis (0,1,0)
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddTorque(-Vector3.up * impulseForce, ForceMode.Impulse);
        }
    }
}
