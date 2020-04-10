using UnityEngine;

namespace Utils.Properties
{
    public class FloatProperty : AbstractProperty<float>
    {
        public override float Value
        {
            get => base.Value;
            set
            {
                if (Mathf.Abs(Value - value) <= Mathf.Abs(Value * 1e-6f)) return;
                base.Value = value;
            }
        }
    }
}