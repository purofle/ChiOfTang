using UnityEngine;

namespace ChiOfTang.GamePlay
{
    public class GameCharacterController : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;

        [SerializeField] private bool isRunning;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (isRunning)
            {
                characterController.Move(Vector3.forward * Time.deltaTime);
            }
        }
    }
}
