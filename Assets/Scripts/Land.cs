using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class Land : MonoBehaviour {

	public int water;
	public int fertilization;
	public bool insects;
	
	// Update is called once per frame
	void Start () {
		// The dirt starts to dry out
		InvokeRepeating("dryOut", 60.0f, 30.0f);
		// The plant uses the fertilizer
		InvokeRepeating("eatingFertilizer", 120.0f, 30.0f);
		// Randomly call insects on your plant
		InvokeRepeating("callInsects", 2.0f, 0.1f);
	}

	void callInsects() {
		float toBeOrNot = Random.value;
		Debug.Log(toBeOrNot);
		if (toBeOrNot < 0.25) {
			Debug.Log("Bwaaa insects are eating my roots");
			this.setInsects(true);
		}
	}

	void dryOut() {
		if (this.getWater() <= 0) {
			//TODO: Start to rot after some time
			Debug.Log("Pls water :C");
		} else {
			this.setWater(this.getWater()-10);
		}
	}

	void eatingFertilizer() {
		if (this.getFertilization() <= 0) {
			//TODO: Start to rot after some time
			Debug.Log("Vitamins pls :C");
		} else {
			this.setFertilization(this.getFertilization()-10);
		}
	}

	public int getWater() {
		return this.water;
	}

	public void setWater(int newWater) {
		this.water = newWater;
	}

	public int getFertilization() {
		return this.fertilization;
	}

	public void setFertilization(int newFertilization) {
		this.fertilization = newFertilization;
	}

	public bool getInsects() {
		return this.insects;
	}

	public void setInsects(bool insects) {
		this.insects = insects;
	}
}
