using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private CharacterController _characterController;
        [SerializeField]
        private float _movementSpeed = 2.0f;
        private float _jumpHeight = 2.4f;
        private float gravity = 9.81f;
        public static PlayerController instance;
        private bool isGrounded;
        private LayerMask groundMask = 6;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
                Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            // Biết được đang nhấn lên hay xuống, trái hay phải.
            var x = Input.GetAxis("Horizontal");
            var z = Input.GetAxis("Vertical");  // Trong trường hợp này. Vertical sẽ là trục Z của chúng ta.
            var move = transform.forward * z + transform.right * x; // * cho direction forward(trục z) và right(trục x).
            _characterController.Move(move * _movementSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
               // move = transform.up *
            }

            //Check if player stands on ground
            var ray = new Ray(transform.position, Vector3.down);
            var hitInfo = new RaycastHit();
            //isGrounded = Physics.Raycast(ray, out hitInfo, checkGroundLength, groundMask);
            if(isGrounded)
            {
                
            }
        }
    }
}
