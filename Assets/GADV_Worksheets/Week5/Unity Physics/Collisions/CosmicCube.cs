using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmicCube : MonoBehaviour
{
    // Help from ChatGPT
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.red; // Start as red
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = Color.green; // Turn green on collision
    }

    void OnCollisionExit(Collision collision)
    {
        rend.material.color = Color.red; // Return to red when collision ends
    }
}
