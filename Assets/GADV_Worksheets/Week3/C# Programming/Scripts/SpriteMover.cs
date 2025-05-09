using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GADVDataTypes 
{
    public class SpriteMover : MonoBehaviour
    {
        private int moveSpeed = 3;
        private float timeElapsed = 2.5f;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            float totalMovement = moveSpeed + timeElapsed;
            transform.position = new Vector3(totalMovement, 0, 0);

            var roundedSpeed = totalMovement;
            roundedSpeed = (int)totalMovement;
        }
    }
}

