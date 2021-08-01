using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class SelectableObj : MonoBehaviour
    {
        [SerializeField]
        private TextMesh _txtDotPercentage;

        public float DotPercentage { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            SelectionManager.Instance.AddSelectableObject(this);
        }

        // Update is called once per frame
        void Update()
        {
            _txtDotPercentage.text = DotPercentage.ToString();
        }
    }
}
