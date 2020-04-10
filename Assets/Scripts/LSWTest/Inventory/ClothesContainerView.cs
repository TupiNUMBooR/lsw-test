using UnityEngine;
using Utils.GameObjects;

namespace LSWTest.Inventory
{
    [RequireComponent(typeof(ClothesContainer))]
    public class ClothesContainerView : Modifier<ClothesContainer>
    {
        public Transform container;
        public GameObject current;
        public GameObject inactiveIcon;

        protected override void Awake()
        {
            base.Awake();
            modified.ChangeEvent += UpdateIcon;
            Singletone.I.money.ChangeEvent += UpdateView;
            Singletone.I.selectedClothes.ChangeEvent += UpdateView;
            UpdateIcon();
        }

        void OnDestroy()
        {
            modified.ChangeEvent -= UpdateIcon;
            Singletone.I.money.ChangeEvent -= UpdateView;
            Singletone.I.selectedClothes.ChangeEvent -= UpdateView;
        }

        void UpdateIcon()
        {
            Destroy(current);
            if (modified.clothes) current = Instantiate(modified.clothes.prefab, container);
            UpdateView();
        }

        void UpdateView()
        {
            inactiveIcon.SetActive(modified.isPaid && !modified.CanChangeClothes(Singletone.I.selectedClothes.clothes));
        }
    }
}