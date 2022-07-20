using UnityEngine;

namespace Common
{
    public class CameraMovement : MonoBehaviour
    {
        public float cameraSpeed;

        private void Update()
        {
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        }
    }
}

