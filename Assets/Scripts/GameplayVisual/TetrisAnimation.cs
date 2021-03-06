using UnityEngine;

namespace ClassicTetris.GameplayVisual
{
    public class TetrisAnimation : MonoBehaviour
    {
        public Animator Animator;
        
        private float _timer;

        private void Update()
        {
            if (_timer > 0.5f)
            {
                _timer = 0;
                this.gameObject.SetActive(false);
            }

            _timer += Time.deltaTime;
        }
    }
}
