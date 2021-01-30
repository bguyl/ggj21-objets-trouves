namespace Guyl.ObjetsTrouves.Inputs
{
	using System;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	
	[RequireComponent(typeof(Rigidbody2D), typeof(PlayerProxy))]
	public class TwoDimMovement : MonoBehaviour, ITwoAxesHandler
	{
		[SerializeField] private FloatReference _speed;
		[SerializeField] private FloatReference _animationEpsilon = new FloatReference(0.1f);
		private Rigidbody2D _rigidbody;
		private PlayerProxy _player;
		private static readonly int RUN = Animator.StringToHash("Run");

		public Vector2 TwoAxesInput { get; set; }

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
			_player = GetComponent<PlayerProxy>();
		}

		private void FixedUpdate()
		{
			_rigidbody.AddForce(TwoAxesInput * Time.fixedDeltaTime * _speed);

			if (_rigidbody.velocity.x < _animationEpsilon)
			{
				_player.Renderer.flipX = true;
			}
			else if (_rigidbody.velocity.x > _animationEpsilon)
			{
				_player.Renderer.flipX = false;
			}
			
			if (_rigidbody.velocity.magnitude > _animationEpsilon)
			{
				_player.Animator.SetBool(RUN, true);
			}
			else
			{
				_player.Animator.SetBool(RUN, false);
			}
		}
	}
}