namespace developer0223._20240403
{
	// System
	using System.Collections;

	// Unity
	using UnityEngine;

	public class Cube : MonoBehaviour
	{
		// private serializable variables
		[SerializeField] private float livingTime = 3.0f;

		public void ResetAfterTime()
        {
			StopAllCoroutines();
			StartCoroutine(Co_ResetAfter(livingTime));
		}

		private IEnumerator Co_ResetAfter(float time)
        {
			yield return new WaitForSeconds(time);
			ObjectPool.Instance.ResetForPool(this);
        }
    }
}