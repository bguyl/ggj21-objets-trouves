namespace Guyl.ObjetsTrouves
{
	using System;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	using UnityEngine.InputSystem;

	[RequireComponent(typeof(PlayerInput))]
	public class VictoryChecker : MonoBehaviour
	{
		private static bool _victoryEventTriggered;
		[SerializeField] private VoidEvent _victoryEvent;
		[SerializeField] private FloatReference _victoryRange = new FloatReference(0.2f);
		private PlayerInput _playerInput;

		public VoidEvent VictoryEvent
		{
			get => _victoryEvent;
			set => _victoryEvent = value;
		}

		[ContextMenu("Reset")]
		public void Reset()
		{
			_playerInput.ActivateInput();
			_victoryEventTriggered = false;
			enabled = true;
		}

		private void Awake()
		{
			_playerInput = GetComponent<PlayerInput>();
		}

		private void FixedUpdate()
		{
			if (_victoryEventTriggered)
			{
				enabled = false;
				_playerInput.DeactivateInput();
				return;
			}

			Collider2D[] collider2Ds = Physics2D.OverlapCircleAll(transform.position, _victoryRange);

			int playerCount = 0;
			foreach (Collider2D entity in collider2Ds)
			{
				if (entity.attachedRigidbody && entity.attachedRigidbody.CompareTag("Player")) playerCount++;
			}

			if (playerCount == 4)
			{
				_victoryEventTriggered = true;
				_victoryEvent.Raise();
			}
		}

		private void OnDrawGizmos()
		{
			Gizmos.DrawWireSphere(transform.position, _victoryRange);
		}
	}
}