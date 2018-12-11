using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldObjectCollider : MonoBehaviour {

	bool inside = false;
	Collision col;

	 void OnCollisionEnter(Collision collision){
		 Debug.Log("I believe i'm inside");
		 col = collision;
		 inside = true;
	 }

	 void OnCollisionExit(Collision collision){
		 Debug.Log("or not");
		 col = collision;
		 inside = false;
	 }

	 public bool getInside(){
		 return inside;
	 }

	// What is it colliding with
	 public Collision getCollision(){
		 return col;
	 }
}
