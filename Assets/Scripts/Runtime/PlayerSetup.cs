﻿namespace Guyl.ObjetsTrouves
{
	using System.Collections.Generic;
	using ScriptableObjects;
	using UnityEngine;
	using UnityEngine.InputSystem;

	[RequireComponent(typeof(PlayerInputManager))]
	public class PlayerSetup : MonoBehaviour
	{
		[SerializeField] private ColorProfiles _colorProfiles;
		[SerializeField] private AnimatorProfiles _animatorProfiles;
		[SerializeField] private List<RectTransform> _startingUI;
		private PlayerInputManager _manager;

		private void Awake()
		{
			_manager = GetComponent<PlayerInputManager>();
			_manager.onPlayerJoined += OnPlayerJoined;
		}

		private void OnPlayerJoined(PlayerInput player)
		{
			PlayerProxy proxy = player.GetComponent<PlayerProxy>();
			if (proxy == null) return;
			
			_startingUI[player.playerIndex].gameObject.SetActive(false);
			
			proxy.SetupLayer(player.playerIndex);
			ColorProfiles.ColorProfile colors = _colorProfiles.Profiles[player.playerIndex];
			proxy.Renderer.color = colors.playerColor;
			proxy.Light.color = colors.playerLightColor;
			proxy.Animator.runtimeAnimatorController = _animatorProfiles.Profiles[player.playerIndex];
		}
	}
}