namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public sealed class Golem : Monster, IAttackable
    {
        public override void Move()
        {
            //base.Move();
            Debug.Log($"Golem Moving...");
        }

        public void Attack()
        {
            Debug.Log($"Golem Attacking...");
        }
    }
}