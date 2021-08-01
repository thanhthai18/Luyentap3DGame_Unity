using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerHead : MonoBehaviour
    {
        public float mousespeed;
        public Transform playerBody;
        public GameObject gun;
        private float _xRotation;
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        // Update is called once per frame
        void Update()
        {
            Rotation();
        }

        private void Rotation()
        {
            // lấy vị trí x,y của mouse;
            float x = Input.GetAxis("Mouse X") * mousespeed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * mousespeed * Time.deltaTime;

            _xRotation -= y; // vị trí trục y của mouse tương đương với x của head;
            _xRotation = Mathf.Clamp(_xRotation, -90, 90); // lấy giá trị trong khoản cho phép -90-90

            // xoay gun theo mouse và head ;
            gun.transform.localRotation = transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);

            playerBody.Rotate(Vector3.up * x); // xoay body của player theo trục y(xoay theo trái phải);
        }
    }
}

