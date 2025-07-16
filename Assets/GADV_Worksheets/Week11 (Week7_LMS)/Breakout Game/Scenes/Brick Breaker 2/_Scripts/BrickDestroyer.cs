using System;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class BrickDestroyer : MonoBehaviour {
        public void OnCollisionEnter2D(Collision2D other) {
            if (!other.gameObject.CompareTag("Ball")) return;
            Debug.Log(other.gameObject.GetComponent<SpriteRenderer>().color);
            Debug.Log(UnityEngine.Color.red);

            Sprite brickType = gameObject.GetComponent<SpriteRenderer>().sprite;
            Destroy(gameObject);
        }
    }
}
