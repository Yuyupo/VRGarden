using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class PesticideHeldObject : VRTK_InteractableObject {

	public GameObject collider;
	public override void StartUsing(VRTK_InteractUse usingObject) {
			Debug.Log("I'm the pesticide");
			HeldObjectCollider pesticide = collider.GetComponent<HeldObjectCollider>();

			if (pesticide.getInside() && pesticide.getCollision().gameObject.GetComponent<Land>()) {
				base.StartUsing(usingObject);
				Debug.Log("Killing insects");
				Land land = pesticide.getCollision().gameObject.GetComponent<Land>();
				if (land.getInsects()) {
					land.setInsects(false);
				}
			}
		}
}
