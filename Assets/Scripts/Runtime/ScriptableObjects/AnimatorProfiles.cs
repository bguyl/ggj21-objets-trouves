namespace Guyl.ObjetsTrouves.ScriptableObjects
{
	using System.Collections.Generic;
	using UnityEngine;

	[CreateAssetMenu(fileName = "AnimatorProfiles", menuName = "Guyl/ObjetsTrouves/AnimatorProfile", order = 2)]
	public class AnimatorProfiles : ScriptableObject
	{
		[SerializeField] private List<RuntimeAnimatorController> m_profiles;

		public List<RuntimeAnimatorController> Profiles => m_profiles;
	}
}