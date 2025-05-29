using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitanLifecycle : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Titan-01: Initial boot sequence initiated.");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Titan-01: Power core stable. Ready for action.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Titan-01: Scanning for threats...");
    }

    private void FixedUpdate()
    {
        Debug.Log("Titan-01: Running periodic stability checks.");
    }

    private void LateUpdate()
    {
        Debug.Log("Titan-01: Adjusting targeting systems.");
    }
}
