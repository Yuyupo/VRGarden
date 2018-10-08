using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertilizerHeldObject : HeldObject {

	public GameObject collider;

	public override void Interact() {
		Debug.Log("I'm the fertilizer");
		HeldObjectCollider sprayBottle = collider.GetComponent<HeldObjectCollider>();

		if (sprayBottle.getInside()) {
			Debug.Log("Fertilizing");
			Land land = sprayBottle.getCollision().gameObject.GetComponent<Land>();
			if (land.getFertilization() < 100) {
				land.setFertilization(land.getFertilization()+10);
			} else {
				land.setFertilization(100);
			}
		}
	}
}
