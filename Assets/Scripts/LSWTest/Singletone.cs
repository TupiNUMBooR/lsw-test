using LSWTest.Inventory;
using UnityEngine;
using Utils.Properties;

namespace LSWTest
{
    public class Singletone : MonoBehaviour
    {
        
        public static Singletone I;
        public ClothesContainer selectedClothes;
        public FloatProperty money;

        void OnEnable()
        {
            if (I == null) I = this;
        }
    }
}