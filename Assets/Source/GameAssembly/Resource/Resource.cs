using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonTask.GameAssembly
{
    public class Resource
    {
        public readonly ResourceData data;

        private int amount;

        public System.Action<int> OnAmountValueChanged;

        public int Amount
        {
            get => amount;
            set
            {
                if (value == amount) return;
                amount = value;
                OnAmountValueChanged?.Invoke(value);
            }
        }

        public Resource(ResourceData data)
        {
            this.data = data;
        }
    }
}
