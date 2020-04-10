using UnityEngine;
using Utils.GameObject;

namespace LSWTest.Inventory
{
    [RequireComponent(typeof(ClothesContainer))]
    public class ClothesContainerView : Modifier<ClothesContainer>
    {
        public Transform container;
        public GameObject current;

        protected override void Awake()
        {
            base.Awake();
            modified.ChangeEvent += OnChange;
        }

        void OnDestroy()
        {
            modified.ChangeEvent -= OnChange;
        }

        void OnChange()
        {
            Destroy(current);
            current = Instantiate(modified.clothes.prefab, container);
        }
    }
}