using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Shooter : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public GameObject gun;
        public float fireRate;
        private float _timeNextShoot;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            if (_timeNextShoot < Time.time)
            {
                Instantiate(bulletPrefab, gun.transform.position, gun.transform.rotation);

                _timeNextShoot = Time.time + 1 / fireRate;
            }

        }
    }
}

