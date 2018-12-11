using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : MonoBehaviour {
	private bool infected;
	public Material deathColor;

	public void childRotter() {
		List<Branch> branches = new List<Branch>();
		int childCount = transform.childCount;

		for (int i = 0; i < childCount; i++) {
			Branch branch = transform.GetChild (i).GetComponent<Branch>();
			if (branch) {
				branches.Add (branch);
			}
		}

		if (branches.Count == 0) {
			Infection();
		} else {
			int count = branches.Count;
			int rnd = (int)Mathf.Round (Random.value * (count-1));
			branches[rnd].childRotter();
		}
	}	

	public bool isInfected() {
		return this.infected;
	}

	public void showInfection() {
		this.infected = true;
		Renderer green = GetComponent<Renderer> ();
		green.material =  deathColor;
	}

	IEnumerator Infection() {
		showInfection ();
		// Gets ALL sub branches
		Branch[] infectableBranches = GetComponentsInChildren<Branch>();
		if (infectableBranches != null) {
			foreach (Branch branch in infectableBranches) {
				if (!branch.isInfected()) {
					branch.showInfection();
				} 
			}
		}
		yield return new WaitForSeconds (2); 
		Branch parentBranch = transform.parent.GetComponent<Branch>();	
		if (parentBranch != null) {
			StartCoroutine (parentBranch.Infection ());
		}
	}
}