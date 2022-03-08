

using UnityEngine;
using System.Collections;

public class RateGooglePlay : MonoBehaviour {

	public void RateUs()
    {
        Application.OpenURL(Constants.ASSETSTORE_URL);
    }
}
