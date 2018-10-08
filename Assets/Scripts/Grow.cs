using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {
	public GameObject small;
	public GameObject big;
	public bool growing;

	void Start () {
		if(growing) {
		/* The plant grows
		** TODO: grows only if water/fertilization and so is sufficient
		** InvokeRepeating("grow", 5.0f, 0.0f); 
		*/
		}
	}

	public void grow() {
		small.SetActive (false);
		big.SetActive(true);
	}
}
