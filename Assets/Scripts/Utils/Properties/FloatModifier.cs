using UnityEngine;
using Utils.GameObjects;

namespace Utils.Properties
{
    [RequireComponent(typeof(FloatProperty))]
    public abstract class FloatModifier : Modifier<FloatProperty>
    {
    }
}