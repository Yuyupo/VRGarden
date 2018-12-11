using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WatercanHeldObject : VRTK_InteractableObject {

	public GameObject collider;

	public override void StartUsing(VRTK_InteractUse usingObject) {
		// Debug.Log("I'm the water can");
		HeldObjectCollider can = collider.GetComponent<HeldObjectCollider>();
		if(can.getInside() && can.getCollision().gameObject.GetComponent<Land>()) {
			base.StartUsing(usingObject);
			// Debug.Log("Watering");
			Land land = can.getCollision().gameObject.GetComponent<Land>();
			if (land.getWater() < 100) {
				land.setWater(land.getWater()+10);
			} else {
				land.setWater(100);
			}
		}
	}

}
