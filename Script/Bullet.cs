using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullet
{
    public class Bullet : MonoBehaviour
    {
        public float move_speed;
        public GameObject explosion;
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("wall"))
            {
                var g = Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(g, 1);
                Destroy(gameObject);
            }
        }
    }
}

