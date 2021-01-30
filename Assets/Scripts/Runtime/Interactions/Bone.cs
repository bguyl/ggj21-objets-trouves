namespace Guyl.ObjetsTrouves
{
	using UnityEngine;

	[RequireComponent(typeof(Collider2D))]
	public class Bone : MonoBehaviour, IInteractable
	{
		public void Interact()
		{
			Debug.Log("Interacted !");
		}
	}
}