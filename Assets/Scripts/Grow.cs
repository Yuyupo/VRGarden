using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour {
	public GameObject small;
	public GameObject big;
	public GameObject blossoms;
	public Transform prefab;
	private bool adult;
	private bool blossoming;
	public Land land;

	void Start () {
		Debug.Log("Calling grow");
		InvokeRepeating("grow", 5f, 0.1f);
		Debug.Log("Calling blossoming");
		InvokeRepeating("blossom", 10.0f, 10f);
		Debug.Log("Calling spawnCherry");
		InvokeRepeating("spawnCherry", 15.0f, 10f);	
	}

	private bool happy(){
		// Debug.Log("Happy little tree");
		if(land.getWater()>80 && land.getFertilization() > 80 && !land.getInsects()) {
			return true;
		}
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

	public void spawnCherry(){
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
}
