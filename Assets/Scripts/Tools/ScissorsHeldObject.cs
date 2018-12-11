using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ScissorsHeldObject : VRTK_InteractableObject {

	public override void StartUsing(VRTK_InteractUse usingObject) {
		base.StartUsing(usingObject);
		Debug.Log("I'm the scissors");
	}

	void OnCollisionEnter (Collision col) {
		var branch = col.gameObject.GetComponent<Branch>();
		if (col != null && branch && branch.isInfected()) {
            //Destroy(col.gameObject);
			//var branch = col.gameObject.GetComponent<Branch>();
			var joint = col.gameObject.GetComponent<FixedJoint>();
			Destroy(joint);
			DestroyBranch(branch);
        }
    }
	IEnumerator DestroyBranch(Branch branch) {
		yield return new WaitForSeconds (5); 
		DestroyBranch(branch);
	}
}
