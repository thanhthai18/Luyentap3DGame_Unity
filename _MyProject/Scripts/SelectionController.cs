using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class SelectionController : MonoBehaviour, ISelectable
    {
        private static SelectableObj _selectableObj;

        [SerializeField]
        private float _threshold = 0.98f;
        [SerializeField]
        private float _closeRange;

        public void RemoveItem(SelectableObj item)
        {
            SelectionManager.Instance.SelectableObjs.Remove(item);
        }

        public SelectableObj Check(Ray ray)
        {
            _selectableObj = null;

            var closest = 0f;
            for (int itemIndex = 0; itemIndex < SelectionManager.Instance.SelectableObjs.Count; itemIndex++)
            {
                var selectObj = SelectionManager.Instance.SelectableObjs[itemIndex];
                var rayDirection = ray.direction;
                var itemDirection = selectObj.transform.position - ray.origin;

                var dotProduct = Vector3.Dot(rayDirection, itemDirection.normalized);
                selectObj.DotPercentage = dotProduct;
                closest = dotProduct;

                var distance = Vector3.Distance(transform.position, selectObj.transform.position);
                bool isCloseRange = distance <= _closeRange;
                if (dotProduct >= _threshold && dotProduct >= closest && isCloseRange)
                {
                    _selectableObj = selectObj;
                }
            }

            return _selectableObj;
        }

        public Transform GetTransform()
        {
            return _selectableObj.transform;
        }

        public static bool HasSelectableObj()
        {
            return _selectableObj;
        }
    }
}
