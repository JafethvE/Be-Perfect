using UnityEngine;

namespace BePerfect
{ 
    public class CameraTarget : MonoBehaviour
    {
        [SerializeField]
        private new Transform transform;

        [SerializeField]
        private float rotationSpeed;

        private void Update()
        {
            Rotate();
        }

        private void Rotate()
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}