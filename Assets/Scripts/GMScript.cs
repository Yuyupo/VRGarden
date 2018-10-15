using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour {

	public Transform grass;

	// Use this for initialization
	void Start () {
		for (int xPos = -8; xPos < 10; xPos += 2) {
			for (int yPos = 5; yPos > -6; yPos -= 2) {
				Instantiate (grass, new Vector3 (yPos, 0, xPos), grass.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
