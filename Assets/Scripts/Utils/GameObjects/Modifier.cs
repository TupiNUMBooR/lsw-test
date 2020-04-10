using UnityEngine;

namespace Utils.GameObjects
{
    public abstract class Modifier<T> : MonoBehaviour
    {
        protected T modified;

        protected virtual void Awake()
        {
            modified = GetComponent<T>();
        }
    }
}