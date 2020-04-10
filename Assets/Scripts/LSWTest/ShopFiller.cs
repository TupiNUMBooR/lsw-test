using LSWTest.Inventory;
using UnityEngine;
using Utils;

namespace LSWTest
{
    public class ShopFiller : MonoBehaviour
    {
        public int slotsAmount = 24;
        public int clothesAmount = 14;
        public ClothesContainer containerPrefab;
        public Clothes[] clothesPrefabs;
        
        void Awake()
        {
            for (var i = 0; i < slotsAmount; i++)
            {
                var cc = Instantiate(containerPrefab, transform);
                if (i < clothesAmount) cc.clothes = clothesPrefabs.Random();
                cc.gameObject.SetActive(true);
            }
            Destroy(this);
        }
    }
}