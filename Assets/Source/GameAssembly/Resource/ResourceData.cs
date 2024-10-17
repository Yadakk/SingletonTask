using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonTask.GameAssembly
{
    [CreateAssetMenu(fileName = "New Resource Data", menuName = "Data/Resource Data", order = 51)]
    public class ResourceData : ScriptableObject
    {
        [field: SerializeField]
        public ResourceType ResourceType { get; private set; }

        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public Sprite Sprite { get; private set; }
    }
}
