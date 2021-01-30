namespace Guyl.ObjetsTrouves
{
	using ScriptableObjects;
	using UnityEngine;
	using UnityEngine.InputSystem;

	[RequireComponent(typeof(PlayerInputManager))]
	public class PlayerSetup : MonoBehaviour
	{
		[SerializeField] private ColorProfiles _colorProfiles;
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
			
			proxy.SetupLayer(player.playerIndex);
			ColorProfiles.ColorProfile colors = _colorProfiles.Profiles[player.playerIndex];
			proxy.Renderer.color = colors.playerColor;
			proxy.Light.color = colors.playerLightColor;
		}
	}
}