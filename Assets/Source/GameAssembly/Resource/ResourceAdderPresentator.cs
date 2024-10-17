using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SingletonTask.GameAssembly
{
    [RequireComponent(typeof(TMP_InputField))]
    public class ResourceAdderPresentator : MonoBehaviour
    {
        [SerializeField]
        private ResourceDropdown resourceDropdown;

        private TMP_InputField inputField;

        private void Awake()
        {
            inputField = GetComponent<TMP_InputField>();
        }

        public void AddToResource()
        {
            resourceDropdown.SelectedResource.Amount += System.Convert.ToInt32(inputField.text);
        }
    }
}
