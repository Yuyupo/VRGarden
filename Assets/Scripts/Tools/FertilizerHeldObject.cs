using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FertilizerHeldObject : VRTK_InteractableObject {

	public GameObject collider;

	public override void StartUsing(VRTK_InteractUse usingObject) {
		// Debug.Log("I'm the fertilizer");
		HeldObjectCollider sprayBottle = collider.GetComponent<HeldObjectCollider>();

		if (sprayBottle.getInside() && sprayBottle.getCollision().gameObject.GetComponent<Land>()) {
			base.StartUsing(usingObject);
			// Debug.Log("Fertilizing");
			Land land = sprayBottle.getCollision().gameObject.GetComponent<Land>();
			if (land.getFertilization() < 100) {
				land.setFertilization(land.getFertilization()+10);
			} else {
				land.setFertilization(100);
			}
		}
	}
}
