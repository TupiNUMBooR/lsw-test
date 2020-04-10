using UnityEngine;
using UnityEngine.EventSystems;
using Utils.GameObject;

namespace LSWTest.Inventory
{
    [RequireComponent(typeof(ClothesContainer))]
    public class ClothesContainerClick : Modifier<ClothesContainer>, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            modified.ChangeClothes(Singletone.I.selectedClothes);
        }
    }
}