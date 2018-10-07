using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {
	public GameObject small;
	public GameObject big;

	void Start () {
		InvokeRepeating("grow", 5.0f, 0.0f);
	}

	public void grow(){
		small.SetActive (false);
		big.SetActive(true);
	}
}
