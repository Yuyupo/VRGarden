using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspector : HeldObject {

	public GameObject collider;

	public override void Interact() {
		Debug.Log("inspecting");
	}
}
