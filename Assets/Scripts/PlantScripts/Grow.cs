using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {
	public GameObject small;
	public GameObject big;
	public GameObject blossoms;
	public GameObject rottable;
	public Transform prefab;
	public GameObject happytext;
	private bool adult;
	private bool blossoming;
	public Land land;

	void Start () {
		Debug.Log(this.adult);
		Debug.Log("Calling rot");
		InvokeRepeating("rotting", 15.0f, 10f);	
		Debug.Log("Calling grow");
		InvokeRepeating("grow", 5f, 0.1f);
		Debug.Log("Calling blossoming");
		InvokeRepeating("blossom", 10.0f, 10f);
		Debug.Log("Calling spawnFruit");
		InvokeRepeating("spawnFruit", 15.0f, 10f);
		
	}

	private bool happy(){
		// Debug.Log("Happy little tree");
		if(land.getWater()>80 && land.getFertilization() > 80 && !land.getInsects()) {
		// if(land.getWater()>80 && land.getFertilization() > 80) {
			happytext.SetActive(true);
			return true;
		}
		happytext.SetActive(false);
		return false;
	}	

	public void grow() {
		if (happy()) {
			// Debug.Log("Yay i just grew");
			small.SetActive (false);
			big.SetActive(true);
			adult = true;
		}
	}

	public void spawnFruit(){
		if (happy()) {
			// Debug.Log("Spawning cherry");
			float r = Random.value/10;
			Instantiate(prefab, new Vector3(0.022f+r,0.963f,0.306f-r), Quaternion.identity);
		}
	}

	public void blossom() {
		if (happy()) {
			// Debug.Log("Enjoy all the flowers");
			blossoms.SetActive(true);
			blossoming = true;
		}
	}

	public void rotting() {
		 Debug.Log("Rotting your sad sad plant");
		if (!happy() && !adult) {
			Branch branch = rottable.GetComponent<Branch>();
			// If there is a branch rot it
			Debug.Log(branch);
			if (branch) {
				Debug.Log("Rot");
				branch.childRotter ();
			}
		}
	}
}
