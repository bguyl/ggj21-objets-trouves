namespace Guyl.ObjetsTrouves
{
	using UnityEngine;
	using UnityEngine.Experimental.Rendering.Universal;

	public class PlayerProxy : MonoBehaviour
	{
		[SerializeField] private SpriteRenderer _renderer;
		[SerializeField] private Light2D _light;
		[SerializeField] private GameObject _virtualCamera;
		[SerializeField] private Camera _camera;

		public SpriteRenderer Renderer => _renderer;
		public Light2D Light => _light;
		public GameObject VirtualCamera => _virtualCamera;
		public Camera Camera => _camera;

		public void SetupLayer(int playerIndex)
		{
			int layer = playerIndex + 6;
			_virtualCamera.layer = layer;
			int bitMask = (1 << layer)
			              | (1 << 0)
			              | (1 << 1)
			              | (1 << 2)
			              | (1 << 4)
			              | (1 << 5)
			              | (1 << 8);
			_camera.cullingMask = bitMask;
			_camera.gameObject.layer = layer;
		}
	}
}