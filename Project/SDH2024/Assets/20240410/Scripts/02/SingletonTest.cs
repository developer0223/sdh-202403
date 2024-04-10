namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public class SingletonTest : MonoBehaviour
    {
        private void Start()
        {
            TestManager.Instance.TestDebug("Hello World!");
        }
    }
}