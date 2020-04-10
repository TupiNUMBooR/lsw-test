using System;
using UnityEngine;

namespace LSWTest.Inventory
{
    [RequireComponent(typeof(ClothesContainer))]
    public class ClothesContainer : MonoBehaviour
    {
        public Clothes clothes;
        public bool isPaid;
        public bool limited;
        public ClothesType limitType;
        public event Action ChangeEvent;

        public bool CanChangeClothes(Clothes c)
        {
            if (limited && c.type != limitType) return false;
            if (Singletone.I.money.Value <= GetChangePrice(c)) return false;
            return true;
        }
        
        public virtual Clothes ChangeClothes(Clothes c)
        {
            if (!CanChangeClothes(c)) return c;
            
            var old = clothes;
            if (c == old) return c;
            
            clothes = c;
            Singletone.I.money.Value -= GetChangePrice(c);
            ChangeEvent?.Invoke();
            return old;
        }

        public float GetChangePrice(Clothes c)
        {
            if (!isPaid) return 0;
            var m = clothes.cost;
            if (c != null) m -= c.cost;
            return m;
        }
    }
}