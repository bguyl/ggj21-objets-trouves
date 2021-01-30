namespace Guyl.ObjetsTrouves
{
	using System;
	using System.Collections;
	using Inputs;
	using UnityEngine;

	[RequireComponent(typeof(Collider2D))]
	public class InteractBehaviour : MonoBehaviour, IActionHandler
	{
		private Coroutine _deactivationRoutine;
		private Collider2D _collider;
		
		public bool Performed { get; set; }

		private void Awake()
		{
			_collider = GetComponent<Collider2D>();
			_collider.enabled = false;
		}

		private void FixedUpdate()
		{
			if (!Performed) return;

			Activate();
			Performed = false;
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			IInteractable interactable = other.GetComponent<IInteractable>();
			interactable?.Interact();
		}

		private void Activate()
		{
			if (_deactivationRoutine != null)
			{
				StopCoroutine(_deactivationRoutine);
			}

			_collider.enabled = true;

			_deactivationRoutine = StartCoroutine(DeactivationRoutine());
		}
		
		private IEnumerator DeactivationRoutine()
		{
			yield return null;
			_collider.enabled = false;
		}
	}
}