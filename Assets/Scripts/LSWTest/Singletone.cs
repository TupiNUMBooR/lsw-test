using LSWTest.Inventory;
using Utils.Properties;

namespace LSWTest
{
    public class Singletone
    {
        public static Singletone I;
        public Clothes selectedClothes;
        public FloatProperty money;

        void OnEnable()
        {
            if (I == null) I = this;
        }
    }
}