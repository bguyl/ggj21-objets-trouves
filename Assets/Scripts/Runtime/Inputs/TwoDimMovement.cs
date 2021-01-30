namespace Guyl.ObjetsTrouves.Inputs
{
	using System;
	using UnityAtoms.BaseAtoms;
	using UnityEngine;
	
	[RequireComponent(typeof(Rigidbody2D))]
	public class TwoDimMovement : MonoBehaviour, ITwoAxesHandler
	{
		[SerializeField] private FloatReference _speed;
		private Rigidbody2D _rigidbody;

		public Vector2 TwoAxesInput { get; set; }

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			_rigidbody.AddForce(TwoAxesInput * Time.fixedDeltaTime * _speed);	
		}
	}
}