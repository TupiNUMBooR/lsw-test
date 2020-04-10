using UnityEngine;
using UnityEngine.EventSystems;
using Utils.GameObjects;

namespace LSWTest.Inventory
{
    [RequireComponent(typeof(ClothesContainer))]
    public class ClothesContainerClick : Modifier<ClothesContainer>, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            Singletone.I.selectedClothes.ChangeClothes(
                modified.ChangeClothes(Singletone.I.selectedClothes.clothes)
            );
        }
    }
}