using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoopTest : MonoBehaviour
{
    private float lastFixedUpdateTime;
    private float lastUpdateTime;
    private float lastLateUpdateTime;

    private void FixedUpdate()
    {
        float deltaTime = Time.time - lastFixedUpdateTime;
        lastFixedUpdateTime = Time.time;
        Debug.Log($"FixedUpdate: {deltaTime:F4}s since last call.");
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.time - lastUpdateTime;
        lastUpdateTime = Time.time;
        Debug.Log($"Update: {deltaTime:F4}s since last call.");
    }

    private void LateUpdate()
    {
        float deltaTime = Time.time - lastLateUpdateTime;
        lastLateUpdateTime = Time.time;
        Debug.Log($"LateUpdate: {deltaTime:F4}s since last call.");
    }
}
