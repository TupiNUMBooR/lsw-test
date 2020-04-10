using System;
using UnityEngine;

namespace Utils.Properties
{
    public class FloatWithPlayerPrefs : FloatModifier
    {
        public string key;

        float Value
        {
            get => PlayerPrefs.HasKey(key) ? PlayerPrefs.GetFloat(key) : modified.initValue;
            set
            {
                if (Math.Abs(value - modified.initValue) < 1e-6f)
                    PlayerPrefs.DeleteKey(key);
                else
                    PlayerPrefs.SetFloat(key, value);
            }
        }

        protected override void Awake()
        {
            base.Awake();
            modified.Value = Value;
            modified.ChangeEvent += OnChange;
        }

        void OnDestroy()
        {
            modified.ChangeEvent -= OnChange;
        }

        void OnChange()
        {
            Value = modified.Value;
        }
    }
}