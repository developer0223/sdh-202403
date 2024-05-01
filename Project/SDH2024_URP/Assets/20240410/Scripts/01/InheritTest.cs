namespace developer0223._20240410
{
    // Unity
    using UnityEngine;

    public class InheritTest : MonoBehaviour
    {
        public Player player = null;
        public Bat bat = null;
        public Golem golem = null;

        public IAttackable batAttackInterface = null;
        public IAttackable golemAttackInterface = null;

        private void Start()
        {
            player.Move();
            player.Move(Vector3.forward);

            bat.Move();
            bat.Attack();
            batAttackInterface.Attack();

            golem.Move();
            golem.Attack();
            golemAttackInterface.Attack();
        }
    }
}