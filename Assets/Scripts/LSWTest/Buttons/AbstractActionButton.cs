using UnityEngine;
using UnityEngine.UI;
using Utils.GameObjects;

namespace LSWTest.Buttons
{
    [RequireComponent(typeof(Button))]
    public abstract class AbstractActionButton : Modifier<Button>
    {
        void Start()
        {
            modified.onClick.AddListener(OnClick);
        }

        void OnDestroy()
        {
            modified?.onClick?.RemoveListener(OnClick);
        }

        public abstract void OnClick();
    }
}