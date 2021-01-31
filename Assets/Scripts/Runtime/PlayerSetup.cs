namespace Guyl.ObjetsTrouves
{
	using System.Collections;
	using System.Collections.Generic;
	using Ludiq;
	using ScriptableObjects;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	using UnityEngine.InputSystem;

	[RequireComponent(typeof(PlayerInputManager))]
	public class PlayerSetup : MonoBehaviour
	{
		[SerializeField] private ColorProfiles _colorProfiles;
		[SerializeField] private AnimatorProfiles _animatorProfiles;
		[SerializeField] private List<RectTransform> _startingUI;
		private PlayerInputManager _manager;

		private List<Transform> _playerSpawners;

		public List<Transform> PlayerSpawners
		{
			get => _playerSpawners;
			set => _playerSpawners = value;
		}

		public List<PlayerInput> InstanciatedPlayers { get; } = new List<PlayerInput>();

		private void Awake()
		{
			_manager = GetComponent<PlayerInputManager>();
			_manager.onPlayerJoined += OnPlayerJoined;
		}

		private void OnPlayerJoined(PlayerInput player)
		{
			InstanciatedPlayers.Add(player);
			
			PlayerProxy proxy = player.GetComponent<PlayerProxy>();
			if (proxy == null) return;
			
			_startingUI[player.playerIndex].gameObject.SetActive(false);
			
			proxy.SetupLayer(player.playerIndex);
			ColorProfiles.ColorProfile colors = _colorProfiles.Profiles[player.playerIndex];
			proxy.Renderer.color = colors.playerColor;
			proxy.Light.color = colors.playerLightColor;
			proxy.Animator.runtimeAnimatorController = _animatorProfiles.Profiles[player.playerIndex];
			
			player.transform.parent.SetParent(transform);
			player.transform.position = PlayerSpawners[player.playerIndex].position;
		}
	}
}