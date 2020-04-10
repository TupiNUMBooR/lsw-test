using UnityEngine;
using UnityEngine.UI;
using Utils.GameObjects;

namespace Utils.Properties
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(Text))]
    public class TextFromFloat : Modifier<Text>
    {
        public FloatProperty floatProperty;
        public string format = "{0:0.#}";

        void Start()
        {
            floatProperty.ChangeEvent += OnChange;
            OnChange();
        }

        void OnDestroy()
        {
            floatProperty.ChangeEvent -= OnChange;
        }

        void OnChange()
        {
            modified.text = string.Format(format, floatProperty.Value);
        }
    }
}