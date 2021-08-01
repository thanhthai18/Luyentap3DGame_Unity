using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FPS
{
    public class Enemy : MonoBehaviour, IShootable
    {
        private NavMeshAgent enemy_ai;

        public float lookRadius;
        private float currenthp;
        private float maxhp;
        [SerializeField] private GameObject particle;

        public float CurrentHp
        {
            get => currenthp;
            set
            {
                currenthp = value;
                //Death();
            }
        }

        private void Death()
        {
            if (CurrentHp <= 0)
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            enemy_ai = GetComponent<NavMeshAgent>();
            CurrentHp = maxhp;
        }

        private void Update()
        {
            enemy_ai.SetDestination(PlayerController.instance.transform.position);
            InstantiateEffect(particle, gameObject.transform.position, Quaternion.identity, 0.1f);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, lookRadius);
        }

        public void InstantiateEffect(GameObject effectPrefab, Vector3 hitPosition, Quaternion rotation, float destroyTime)
        {
            Instantiate(effectPrefab, hitPosition, rotation);
            Destroy(gameObject, destroyTime);
        }
    }
}