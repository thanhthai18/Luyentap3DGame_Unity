using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class InteractController : MonoBehaviour
    {
        [SerializeField]
        private SelectionController _selectionController;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var ray = new Ray(transform.position, transform.forward);
            var selectObj = _selectionController.Check(ray);
            if (selectObj != null && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log($"Interact with {selectObj.name}");
                _selectionController.RemoveItem(selectObj);
                Destroy(selectObj.gameObject);
            }
            //RaycastHit hit;
            //bool isHitSomething = Physics.Raycast(ray, out hit, float.PositiveInfinity);
            //Debug.DrawRay(transform.position, transform.forward * 10f, Color.blue);
            //if (isHitSomething)
            //{
            //    if (hit.collider.CompareTag("Item"))
            //    {
            //        Debug.Log($"Hit {hit.collider.name}");
            //    }
            //}
        }
    }
}
