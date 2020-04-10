using UnityEngine;

namespace LSWTest
{
    public class FollowMouse : MonoBehaviour
    {
        
        void Update()
        {
            var t = transform;
            t.position = Input.mousePosition;
        }
    }
}