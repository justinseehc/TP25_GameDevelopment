using UnityEngine;

namespace Scenes.Brick_Breaker_2._Scripts {
    public class BallInitializer : MonoBehaviour {
        private Rigidbody2D MyRb { get; set; }
        public float speed = 500f;

        private void Awake() {
            MyRb = GetComponent<Rigidbody2D>();
        }

        private void Start() {
            Invoke(nameof(SetRandomTrajectory), 1f);
        }

        private void SetRandomTrajectory() {
            Vector2 force = Vector2.zero;
            force.x = Random.Range(-0.5f, 0.5f);
            force.y = -1;
        
            MyRb.AddForce(force.normalized * speed);
        }
    }
}
