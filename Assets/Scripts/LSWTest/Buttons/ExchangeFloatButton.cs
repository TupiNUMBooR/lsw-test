using Utils.Properties;

namespace LSWTest.Buttons
{
    public class ExchangeFloatButton : AbstractActionButton
    {
        public FloatProperty subtractProperty;
        public float subtractPropertyAmount = 10;
        public FloatProperty addProperty;
        public float addPropertyAmount = 1;
        
        public override void OnClick()
        {
            var v1 = subtractProperty.Value - subtractPropertyAmount;
            if (v1 < 0) return;
            subtractProperty.Value = v1;
            addProperty.Value += addPropertyAmount;
        }
    }
}