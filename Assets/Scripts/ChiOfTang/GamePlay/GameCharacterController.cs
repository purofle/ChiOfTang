using UnityEngine;

namespace ChiOfTang.GamePlay
{
    public class GameCharacterController : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;

        [SerializeField] private bool isRunning;
        private Animator _animator;
        private static readonly int IsRunning = Animator.StringToHash("isRunning");
        private Touch _touch;

        void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        private void Update()
        {
            CheckMobileInput();
            if (isRunning)
            {
                Running();
            }
            else if (_animator.GetBool(IsRunning))
            {
                _animator.SetBool(IsRunning, false);
            }
        }

        private void Running()
        {
            characterController.Move(Vector3.forward * (Time.deltaTime * 5));
            if (!_animator.GetBool(IsRunning))
            {
                _animator.SetBool(IsRunning, true);
            }
        }

        private void CheckMobileInput()
        {
            // 手指在屏幕上再跑
            if (Input.touchCount <= 0) return;
            _touch = Input.GetTouch(0);
            isRunning = _touch.phase switch
            {
                TouchPhase.Began => true,
                _ => isRunning
            };

            // 滑动移动
            
        }
    }
}
