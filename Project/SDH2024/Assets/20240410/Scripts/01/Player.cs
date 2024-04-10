namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public class Player : Character
    {
        public void Move()
        {
            Debug.Log($"Player Moving...");
        }

        public void Move(Vector3 direction)
        {
            Debug.Log($"Player Moving to {direction}...");
        }
    }
}