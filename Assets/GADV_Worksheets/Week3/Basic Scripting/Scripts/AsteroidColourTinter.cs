using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidColourTinter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spriteRenderer.color == Color.white)
            {
                spriteRenderer.color = Color.blue;
            }
            else
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
}
