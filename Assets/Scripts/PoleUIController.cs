using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleUIController : MonoBehaviour {
	public GameObject deletePlantUI;
	public GameObject buyPlantUI;
	public Land land;
	public GameObject cherryTree; // TODO:	better way to store plants if there will be more than 1

	public void Start() {
		deletePlantUI.SetActive(false);
		buyPlantUI.SetActive(false);
	}
	public void PoleUIPicker() {
		if (land.plant != null) {
			deletePlantUI.SetActive(true);
			Debug.Log("There is a plant");
		} else {

		buyPlantUI.SetActive(true);
		Debug.Log("There is NO plant");
		}
	}

	public void CloseUI() {
		deletePlantUI.SetActive(false);
		buyPlantUI.SetActive(false);
	}

	public void deletePlant() {
		Destroy(land.getPlant());
		land.setPlant(null);
	}

	public void buyCherryTree() {
		Instantiate(cherryTree, land.transform);
		//land.setPlant(cherryTree);
	}
}
