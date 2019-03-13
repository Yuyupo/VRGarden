using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleUIController : MonoBehaviour {
	public GameObject deletePlantUI;
	public GameObject buyPlantUI;
	public Land land;
	public GameObject cherryTree; // TODO:	better way to store plants if there will be more than 1
	public GameObject catBush;

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
		CloseUI();
		Destroy(land.getPlant());
		land.setPlant(null);
	}

	public void buyCherryTree() {
		CloseUI();
		var tree = Instantiate(cherryTree, land.transform);
		tree.GetComponent<Grow>().setLand(land);
		land.setPlant(tree);
	}

	public void buyCatBush() {
		CloseUI();
		var bush = Instantiate(catBush, land.transform);
		bush.GetComponent<Grow>().setLand(land);
		land.setPlant(bush);
	}
}
