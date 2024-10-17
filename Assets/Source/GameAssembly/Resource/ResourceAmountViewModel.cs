using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SingletonTask.GameAssembly
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class ResourceAmountViewModel : MonoBehaviour
    {
        [SerializeField]
        private ResourceDropdown resourceDropdown;

        private TextMeshProUGUI tmpu;

        private Resource displayedResource;

        private void Awake()
        {
            tmpu = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            resourceDropdown.OnResourceSelected += OnResourceSelectedHandler;
            DisplayResource(resourceDropdown.SelectedResource);
        }

        private void OnResourceSelectedHandler(Resource selectedResource)
        {
            DisplayResource(selectedResource);
        }

        private void DisplayResource(Resource resource)
        {
            if (displayedResource != null)
            {
                displayedResource.OnAmountValueChanged -= OnResourceAmountChangedHandler;
            }

            displayedResource = resource;
            displayedResource.OnAmountValueChanged += OnResourceAmountChangedHandler;
            UpdateView();
        }

        private void OnResourceAmountChangedHandler(int newAmount)
        {
            UpdateView();
        }

        private void UpdateView()
        {
            tmpu.text = $"Amount of {displayedResource.data.name}: {displayedResource.Amount}";
        }
    }
}
