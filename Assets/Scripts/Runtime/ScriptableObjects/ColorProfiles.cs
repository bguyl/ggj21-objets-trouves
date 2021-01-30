namespace Guyl.ObjetsTrouves.ScriptableObjects
{
	using System;
	using System.Collections.Generic;
	using UnityEngine;

	[CreateAssetMenu(fileName = "ColorProfiles", menuName = "Guyl/ObjetsTrouves/ColorProfile", order = 0)]
	public class ColorProfiles : ScriptableObject
	{
		[Serializable]
		public struct ColorProfile
		{
			public Color playerColor;
			public Color playerLightColor;
		}

		[SerializeField] private List<ColorProfile> _profiles = new List<ColorProfile>();

		public List<ColorProfile> Profiles => _profiles;
	}
}