using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public float move_speed;
        public CharacterController characterController;
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {
            Move();
        }
        private void Move()
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            //Vector3 move = transform.right * x + transform.forward * z;
            //characterController.Move(move * move_speed * Time.fixedDeltaTime);

            characterController.Move(transform.forward * z * move_speed * Time.fixedDeltaTime);
        }
    }
}

