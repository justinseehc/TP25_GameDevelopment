using UnityEngine;
using UnityEngine.Serialization;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class PaddleController : MonoBehaviour {

        private Rigidbody2D _myRb;
        private Vector2 _direction;
        public float speed = 30f;
        void Start() {
            _myRb = GetComponent<Rigidbody2D>();
        }

        void Update() {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                _direction = Vector2.left;
            } else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                _direction = Vector2.right;
            } else {
                _direction = Vector2.zero;
            }
        }
        
        void FixedUpdate() {
            if(_direction == Vector2.zero) {
                return;
            }
            
            _myRb.AddForce(_direction * speed);
        }
    }
}
