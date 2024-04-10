namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public abstract class Monster : Character
    {
        public virtual void Move()
        {
            Debug.Log($"Monster Moving...");
        }
    }
}