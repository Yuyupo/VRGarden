using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime;

public class Land : MonoBehaviour {
	public GameObject plant;
	public int water;
	public int fertilization;
	public bool insects;
	public Image insectPicture;
	public Slider waterSlider;
	public Slider fertilizerSlider;
	
	// Update is called once per frame
	void Start () {
		Debug.Log(insectPicture);
		// The dirt starts to dry out
		InvokeRepeating("dryOut", 120.0f, 5.0f);
		// The plant uses the fertilizer
		InvokeRepeating("eatingFertilizer", 120.0f, 5.0f);
		// Randomly call insects on your plant
		InvokeRepeating("callInsects", 120.0f, 5.0f);
	}

	void callInsects() {
		float toBeOrNot = Random.value;
		// Debug.Log(toBeOrNot);
		if (toBeOrNot < 0.05) {
			Debug.Log("Bwaaa insects are eating my roots");
			this.setInsects(true);
		}
	}

	void dryOut() {
		if (this.getWater() <= 0) {
			// Debug.Log("Pls water :C");
		} else {
			this.setWater(this.getWater() - 10);
		}
	}

	void eatingFertilizer() {
		if (this.getFertilization() <= 0) {
			// Debug.Log("Vitamins pls :C");
		} else {
			this.setFertilization(this.getFertilization() - 10);
		}
	}
	
	public GameObject getPlant() {
		Debug.Log(this.plant);
		return this.plant;
	}

	public void setPlant(GameObject newPlant) {
		this.plant = newPlant;
	}
	public int getWater() {
		return this.water;
	}

	public void setWater(int newWater) {
		this.water = newWater;
		waterSlider.value = newWater;
	}

	public int getFertilization() {
		return this.fertilization;
	}

	public void setFertilization(int newFertilization) {
		this.fertilization = newFertilization;
		fertilizerSlider.value = newFertilization;
	}

	public bool getInsects() {
		return this.insects;
	}

	public void setInsects(bool insects) {
		Debug.Log(insectPicture+" "+gameObject.name);
		this.insects = insects;
		if (insects) {
			//insectPicture.setActive(true);
			insectPicture.enabled = true;
		} else {
			//insectPicture.setActive(false);
			insectPicture.enabled = false;
		}
	}
}
