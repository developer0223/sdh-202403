namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public class TestManager : MonoSingleton<TestManager>
    {
        public void TestDebug(string message = "")
        {
            Debug.Log($"message: {message}");
        }
    }
}