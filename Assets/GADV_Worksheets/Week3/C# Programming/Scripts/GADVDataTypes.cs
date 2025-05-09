using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GADVDataTypes
{
    // Exercise 1
    //public class GADVDataTypes : MonoBehaviour
    //{
    //    
    //    private Transform spriteTransform;
    //    private string scale = "2.0a";
    //    // Start is called before the first frame update
    //    void Start()
    //    {
    //        spriteTransform = GetComponent<Transform>();
    //        spriteTransform.localScale = new Vector3(float.Parse(scale), float.Parse(scale), 1f);
    //    }
    //}

    // Exercise 3
    public class VarExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var sprite = GetComponent<SpriteRenderer>();
            var spriteColor = sprite.color;
            var spriteSize = sprite.size;

            Debug.Log("Sprite Color: " + spriteColor);
            Debug.Log("Sprite Size: " + spriteSize);
        }
    }
}