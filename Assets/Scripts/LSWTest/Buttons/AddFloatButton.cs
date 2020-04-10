using Utils.Properties;

namespace LSWTest.Buttons
{
    public class AddFloatButton : AbstractActionButton
    {
        public FloatProperty property;
        public float amount;
        
        public override void OnClick()
        {
            property.Value += amount;
        }
    }
}