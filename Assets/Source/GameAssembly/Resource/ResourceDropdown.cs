using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace SingletonTask.GameAssembly
{
    [RequireComponent(typeof(TMP_Dropdown))]
    public class ResourceDropdown : MonoBehaviour
    {
        private TMP_Dropdown dropdown;

        public System.Action<Resource> OnResourceSelected;

        public Resource SelectedResource => ResourceBankSingleton.Instance.Resources[dropdown.value];

        private void Awake()
        {
            dropdown = GetComponent<TMP_Dropdown>();
        }

        private void Start()
        {
            List<TMP_Dropdown.OptionData> options = new();
            foreach (Resource resource in ResourceBankSingleton.Instance.Resources)
            {
                options.Add(new(resource.data.Name, resource.data.Sprite));
            }

            dropdown.options = options;
            dropdown.onValueChanged.AddListener(OnDropdownValueChangedHandler);
        }

        private void OnDropdownValueChangedHandler(int index)
        {
            OnResourceSelected?.Invoke(SelectedResource);
        }
    }
}