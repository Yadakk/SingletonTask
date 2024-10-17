using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SingletonTask.GameAssembly
{
    public class ResourceBankSingleton : MonoBehaviour
    {
        private readonly List<Resource> resources = new();

        [SerializeField]
        private List<ResourceData> resourceDatas;

        public static ResourceBankSingleton Instance { get; private set; }

        public List<Resource> Resources => resources;

        private void Awake()
        {
            CreateSingleton();
            Init();
        }

        public Resource GetByResourceType(ResourceType resourceType)
        {
            return resources.FirstOrDefault(res => res.data.ResourceType == resourceType);
        }

        private void Init()
        {
            resourceDatas.ForEach(data => resources.Add(new(data)));
        }

        private void CreateSingleton()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
