using UnityEngine.SceneManagement;

namespace LSWTest.Buttons
{
    public class ResetButton : AbstractActionButton
    {
        public override void OnClick()
        {
            SceneManager.LoadScene(0);
        }
    }
}