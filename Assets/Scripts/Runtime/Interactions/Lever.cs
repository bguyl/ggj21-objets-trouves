namespace Guyl.ObjetsTrouves
{
	using System;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	using UnityEngine.Experimental.Rendering.Universal;

	[RequireComponent(typeof(SpriteRenderer))]
	public class Lever : MonoBehaviour, IInteractable
	{
		[SerializeField] private Sprite _onSprite;
		[SerializeField] private Sprite _offSprite;
		[SerializeField] private BoolEvent _toggled;
		[SerializeField] private ParticleSystem _particles;
		[SerializeField] private Light2D _light;
		private bool _value = false;
		private SpriteRenderer _renderer;

		private void Awake()
		{
			_renderer = GetComponent<SpriteRenderer>();
		}

		public void Interact()
		{
			_value = !_value;

			if (_value)
			{
				_renderer.sprite = _onSprite;
				_particles.Stop();
				_light.enabled = !_value;
			}
			else
			{
				_renderer.sprite = _offSprite;
				_particles.Play();
				_light.enabled = !_value;
			}

			_toggled?.Raise(_value);
		}
	}
}