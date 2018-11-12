using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ScissorsHeldObject : VRTK_InteractableObject {

	public override void StartUsing(VRTK_InteractUse usingObject) {
		base.StartUsing(usingObject);
		Debug.Log("I'm the scissors");
	}
}
