using UnityEngine;

namespace Utils.GameObject
{
    public abstract class Modifier<T> : MonoBehaviour
    {
        public T modified;

        protected virtual void Awake()
        {
            modified = GetComponent<T>();
        }
    }
}