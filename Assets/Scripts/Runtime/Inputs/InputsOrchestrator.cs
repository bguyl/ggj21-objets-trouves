namespace Guyl.ObjetsTrouves.Inputs
{
	using System;
	using System.Runtime.InteropServices.ComTypes;
	using UnityEngine;
	using UnityEngine.InputSystem;

	[RequireComponent(typeof(PlayerInput))]
	public class InputsOrchestrator : MonoBehaviour
	{
		private PlayerInput _playerInput;

		[Header("Move handler")]
		[SerializeField] private InputActionReference _moveAction;
		[SerializeField] private TwoDimMovement _twoDimMovement;

		[Header("Interact handler")]
		[SerializeField] private InputActionReference _interactAction;
		[SerializeField] private InteractBehaviour _interactBehaviour;

		private void Awake()
		{
			_playerInput = GetComponent<PlayerInput>();
			_playerInput.onActionTriggered += OnActionTriggered;
		}

		private void OnActionTriggered(InputAction.CallbackContext ctx)
		{
			if (ctx.action.name == _moveAction.action.name)
			{
				_twoDimMovement.TwoAxesInput = ctx.ReadValue<Vector2>();
			}
			else if (ctx.action.name == _interactAction.action.name && ctx.started)
			{
				_interactBehaviour.Performed = true;
			}
		}
	}
}