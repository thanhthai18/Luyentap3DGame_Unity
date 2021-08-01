using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class Canvas_Main : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _pnlInteract;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            _pnlInteract.gameObject.SetActive(SelectionController.HasSelectableObj());
        }
    }
}
