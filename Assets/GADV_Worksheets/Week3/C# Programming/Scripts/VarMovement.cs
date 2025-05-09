using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarMovement : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        var speed = 5.0f;
        var direction = new Vector3(1, 0, 0);

        transform.position += direction * speed * Time.deltaTime;
        // speed = "fast";
    }
}
