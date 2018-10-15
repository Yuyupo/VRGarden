using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatercanHeldObject : HeldObject {

	public GameObject collider;

	public override void Interact() {
		Debug.Log("I'm the water can");
		HeldObjectCollider can = collider.GetComponent<HeldObjectCollider>();
		if(can.getInside() && can.getCollision().gameObject.GetComponent<Land>()) {
			Debug.Log("Watering");
			Land land = can.getCollision().gameObject.GetComponent<Land>();
			if (land.getWater() < 100) {
				land.setWater(land.getWater()+10);
			} else {
				land.setWater(100);
			}
			
		}
	}

}
