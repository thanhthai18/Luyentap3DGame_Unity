using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FPS
{
    public class SelectionManager : MonoBehaviour
    {
        #region Singleton
        private static SelectionManager _instance;
        public static SelectionManager Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        #region Field
        [SerializeField]
        private List<SelectableObj> _selectableObjs = new List<SelectableObj>();
        #endregion

        #region Property
        public List<SelectableObj> SelectableObjs => _selectableObjs;
        #endregion

        private void Awake()
        {
            if (_instance == null)
                _instance = this;
            else
                Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        public void AddSelectableObject(SelectableObj obj)
        {
            _selectableObjs.Add(obj);
        }
    }
}
