namespace Guyl.ObjetsTrouves
{
	using System.Collections;
	using Inputs;
	using UnityEngine;
	
	[RequireComponent(typeof(PlayerProxy))]
	public class InteractBehaviour : MonoBehaviour, IActionHandler
	{
		private Coroutine _deactivationRoutine;
		private PlayerProxy _player;
		[SerializeField] private Collider2D _collider;
		private static readonly int USE = Animator.StringToHash("Use");

		public bool Performed { get; set; }

		private void Awake()
		{
			_player = GetComponent<PlayerProxy>();
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

			_player.Animator.SetBool(USE, true);
			_collider.enabled = true;

			
			_deactivationRoutine = StartCoroutine(DeactivationRoutine());
		}
		
		private IEnumerator DeactivationRoutine()
		{
			yield return null;
			_collider.enabled = false;
			_player.Animator.SetBool(USE, false);
		}
	}
}