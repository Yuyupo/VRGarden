using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk : MonoBehaviour {
	public GameObject tree;
	public GameObject grownTree; 
	public List<Branch> branches;
	private bool dead;

	void Start() {
		/** How often should your tree try to suicide :c
		** TODO: start to rot if water/fertilizer/pesticide is NOT sufficient
		** InvokeRepeating("rotting", 1.0f, 100.0f); 
		*/
	}

	public void rotting() {
		Branch branch = GetComponent<Branch>();
		// If there is a branch rot it
		if (branch) {
			branch.childRotter ();
		}
	}
}
