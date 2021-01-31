namespace Guyl.ObjetsTrouves
{
	using System.Collections.Generic;
	using UnityEngine;

	public class LevelProxy : MonoBehaviour
	{
		[SerializeField] private List<Transform> _playerSpawners;

		public List<Transform> PlayerSpawners => _playerSpawners;
	}
}