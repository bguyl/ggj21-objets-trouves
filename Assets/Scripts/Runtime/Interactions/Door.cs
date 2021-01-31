namespace Guyl.ObjetsTrouves
{
	using System;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;

	[RequireComponent(typeof(SpriteRenderer), typeof(Collider2D))]
	public class Door : MonoBehaviour
	{
		[SerializeField] private BoolEvent _event;
		[SerializeField] private Sprite _closedSprite;
		[SerializeField] private Sprite _openedSprite;
		private Collider2D _collider;
		private SpriteRenderer _renderer;

		private void Awake()
		{
			_renderer = GetComponent<SpriteRenderer>();
			_collider = GetComponent<Collider2D>();
			_event.Register(OnEventRaised);
		}

		private void OnEventRaised(bool value)
		{
			_collider.enabled = !value;
			_renderer.sprite = value ? _openedSprite : _closedSprite;
		}
	}
}