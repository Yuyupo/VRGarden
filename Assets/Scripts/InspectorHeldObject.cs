using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Inspector : VRTK_InteractableObject {

	public GameObject collider;

	public override void StartUsing(VRTK_InteractUse usingObject) {
		base.StartUsing(usingObject);
		Debug.Log("inspecting");
	}
}
