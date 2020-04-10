using UnityEngine;

namespace Utils.GameObjects
{
    public class Cloner : MonoBehaviour
    {
        public int amount;
        public GameObject prefab;

        void Awake()
        {
            for (var i = 0; i < amount; i++)
            {
                Instantiate(prefab, transform).SetActive(true);
            }
            Destroy(this);
        }
    }
}