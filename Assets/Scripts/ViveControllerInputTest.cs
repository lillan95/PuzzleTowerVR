using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveControllerInputTest : MonoBehaviour {

	private SteamVR_TrackedObject trackedObj;

	private SteamVR_Controller.Device Controller
	{
		get { return SteamVR_Controller.Input((int)trackedObj.index); }
	}

	void Awake()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void Update () {
		string flag = "yes";

		//  Logs inputs we get from using the controllers
		if (Controller.GetAxis () != Vector2.zero) {
			Debug.Log (gameObject.name + Controller.GetAxis ());
			flag = "no";
		}

		if (Controller.GetHairTriggerDown ()) {
			Debug.Log (gameObject.name + " Trigger Press");
			flag = "no";
		} 

		if (Controller.GetHairTriggerUp ()) {
			Debug.Log (gameObject.name + " Trigger Release");
			flag = "no";
		} 

		if (Controller.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log (gameObject.name + " Grip Press");
			flag = "no";
		} 

		if (Controller.GetPressUp (SteamVR_Controller.ButtonMask.Grip)) {
			Debug.Log (gameObject.name + " Grip Release");
			flag = "no";
		} 

		if (flag == "yes") {
			Debug.Log ("NO INPUTS");
		}
	}
}
