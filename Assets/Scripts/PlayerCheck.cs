using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerCheck : MonoBehaviour
    {
        public float holdTime;
        public bool IsHolding => isHolding && t >= holdTime;
        private bool isHolding;

        private float t;

        private void Update()
        {
            if (isHolding) t += Time.deltaTime;
        }

        private void OnCollisionEnter(Collision collision)
        {
            HoldGameBallCheck(collision.gameObject);
        }

        private void OnCollisionExit(Collision collision)
        {
            isHolding = false;
            t = 0;
        }

        private void OnCollisionStay(Collision collision)
        {
            HoldGameBallCheck(collision.gameObject);
        }

        private void HoldGameBallCheck(GameObject gameObj)
        {
            if (gameObj.TryGetComponent(out GameBall gb))
            {
                isHolding = true;
                return;
            }

            isHolding = false;
        }
    }
}