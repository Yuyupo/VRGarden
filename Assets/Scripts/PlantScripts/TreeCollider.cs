using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollider : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Scissor") {

		print ("Collisin");

		FixedJoint[] parentJoints = transform.parent.GetComponents<FixedJoint>();
		Rigidbody rigidBody = transform.GetComponent<Rigidbody>();


		foreach (FixedJoint parentJoint in parentJoints) {
			if (parentJoint.connectedBody == rigidBody) {
				Destroy (parentJoint);
			}
		}
	}
	}
}
