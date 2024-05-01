namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public sealed class Bat : Monster, IAttackable
    {
        public override void Move()
        {
            //base.Move();
            Debug.Log($"Bat Moving...");
        }

        public void Attack()
        {
            Debug.Log($"Golem Attacking...");
        }
    }
}