

using UnityEngine;

public class CameraManager : MonoBehaviour {

	public Camera main;

    //Allows us to shake camera 
    [HideInInspector]
	public CameraShake shaker;

    void Awake()
	{
		shaker = main.gameObject.GetComponent<CameraShake> ();
    }


}
