using UnityEngine;

namespace MirageWidget.MirageAPI.Data
{
	[CreateAssetMenu(fileName = "MirageAPISettings", menuName = "Mirage/MirageAPISettings")]
	public class MirageAPISettingsSO : ScriptableObject
	{
		[Tooltip("Unique ID of your game project")]
		[SerializeField] private string _clientID = "";
		
		[Tooltip("Your secret key to access Mirage API")]
		[SerializeField] private string _clientSecret = "";

		public string ClientID => _clientID;

		public string ClientSecret => _clientSecret;
	}
}