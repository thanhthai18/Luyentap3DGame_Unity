using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public interface IShootable
    {
        public float CurrentHp { get; set; }
        void InstantiateEffect(GameObject effectPrefab, Vector3 hitPosition, Quaternion rotation, float destroyTime);
    }
}