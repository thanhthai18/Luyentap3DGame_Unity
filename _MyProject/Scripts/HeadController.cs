using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class HeadController : MonoBehaviour
    {
        [SerializeField]
        private float _lookSpeed;
        [SerializeField]
        private CharacterController _charCtrl;
        private float xAxisRotation = 0f;

        // Start is called before the first frame update
        void Start()
        {
            // Lock trỏ chuột ngay giữa màn hình.
            Cursor.lockState = CursorLockMode.Locked;
            transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        }

        // Update is called once per frame
        void Update()
        {
            LookRotation();
        }

        private void LookRotation()
        {
            // Lấy hướng của mouse X, Y
            var mouseX = Input.GetAxis("Mouse X");
            var mouseY = Input.GetAxis("Mouse Y");

            // Tính ra "độ nhạy" của mouse
            var lookSensitiveX = mouseX * _lookSpeed * Time.deltaTime;
            var lookSensitiveY = mouseY * _lookSpeed * Time.deltaTime;

            // Tính ra góc quay của trục X. Để quay lên quay xuống.
            xAxisRotation -= lookSensitiveY;
            // Chặn góc quay không quá -90 => 90.
            xAxisRotation = Mathf.Clamp(xAxisRotation, -90f, 90f);

            // Apply vào head.
            transform.localRotation = Quaternion.Euler(xAxisRotation, 0f, 0f);
            // Xoay character theo trục Y. Để xoay ngang.
            _charCtrl.transform.Rotate(Vector3.up, mouseX);
        }
    }
}
