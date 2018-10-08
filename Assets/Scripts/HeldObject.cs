using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class  HeldObject : MonoBehaviour {

	[HideInInspector]
	public Controller parent;

	public abstract void Interact();
}