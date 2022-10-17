using Unity.Collections.LowLevel.Unsafe;
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
        void Update()
        {
            CameraFollow();
            CheckMobileInput();
            if (isRunning)
            {
                Running();
            } else if (_animator.GetBool(IsRunning))
            {
                _animator.SetBool(IsRunning, false);
            }
        }

        private void Running()
        {
            characterController.Move(Vector3.forward * Time.deltaTime);
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
                TouchPhase.Ended => false,
                _ => isRunning
            };

            // 滑动移动
            if (_touch.phase != TouchPhase.Moved) return;
            var deltaPosition = _touch.deltaPosition;
            var x = deltaPosition.x;
            var y = deltaPosition.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x > 0)
                {
                    transform.Rotate(Vector3.up, 1);
                }
                else
                {
                    transform.Rotate(Vector3.up, -1);
                }
            }
            else
            {
                if (y > 0)
                {
                    transform.Rotate(Vector3.right, 1);
                }
                else
                {
                    transform.Rotate(Vector3.right, -1);
                }
            }
        }

        void CameraFollow()
        {
            // 相机跟随人物
            
        }
    }
}
