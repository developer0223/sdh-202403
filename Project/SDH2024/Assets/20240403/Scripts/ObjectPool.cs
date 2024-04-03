namespace developer0223._20240403
{
	// System
	using System.Collections.Generic;

	// Unity
	using UnityEngine;

	public class ObjectPool : MonoBehaviour
	{
		#region Singleton
		public static ObjectPool Instance = null;

        private void Awake()
        {
            Instance = this;

			CreateAndAddPoolObject(5);
        }
        #endregion

        // private serializable variables
        [SerializeField] private GameObject go_prefab_cube = null;

		// private variables
		[SerializeField] private Queue<Cube> cubePoolQueue = new Queue<Cube>();

		private void CreateAndAddPoolObject(int count)
        {
			for (int i = 0; i < count; i++)
            {
				cubePoolQueue.Enqueue(CreateObject());
            }
        }

        public Cube CreateObject()
        {
            Cube cube = Instantiate(go_prefab_cube).GetComponent<Cube>();
            cube.gameObject.SetActive(false);
            cube.transform.SetParent(transform);

			return cube;
        }

        public Cube GetObject()
        {
			Cube cube = cubePoolQueue.Count <= 0 ? CreateObject() : cubePoolQueue.Dequeue();
			cube.gameObject.SetActive(true);
			cube.transform.SetParent(null);

			return cube;
		}

		public void ResetForPool(Cube cube)
        {
			cube.gameObject.SetActive(false);
			cube.transform.SetParent(transform);

			cubePoolQueue.Enqueue(cube);
        }
    }
}