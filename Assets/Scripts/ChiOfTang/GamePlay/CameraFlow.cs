using UnityEngine;

namespace ChiOfTang.GamePlay
{
    // 相机跟随
    public class CameraFlow : MonoBehaviour
    {
        private Transform _player;

        void Awake()
        {
            _player = GameObject.FindWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            var cameraTransform = transform;
            var playerTransform = _player.transform;
            
            var pPosition = playerTransform.position;
            var pRotation = playerTransform.rotation;
            var tRotation = cameraTransform.rotation;
            var tPosition = cameraTransform.position;
            
            tPosition.x = (float)(pPosition.x - 0.06);
            tPosition.y = (float)(pPosition.y + 4.301);
            tPosition.z = (float)(pPosition.z + -7.1494);
            cameraTransform.position = tPosition;

            // tRotation.x = (float)16.66;
            tRotation.y = pRotation.y;
            tRotation.z = pRotation.z;
            cameraTransform.rotation = tRotation;
        }
    }
}
