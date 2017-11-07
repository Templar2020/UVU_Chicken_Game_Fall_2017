using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generic : MonoBehaviour {
	// Position
	// public float posX;
	// public float posY = 0.5f;
	// public float posZ;
	public Vector3 pos;
	// Rotate
	// public float rotX;
	// public float rotY;
	// public float rotZ;
	public Quaternion rot;
	// public float rotW;
	// Scale
	// public float x = 1f;
	// public float y = 1f;
	// public float z = 1f;
	public Vector3 scale;


	// Use this for initialization
	void Start () {
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		// transform.position = new Vector3(posX,posY,posZ);
		// transform.rotation = new Quaternion(rotX,rotY,rotZ,rotW); 
		// transform.localScale = new Vector3(x,y,z);

		transform.position = pos;
		transform.rotation = rot;
		scale = Vector3.one;
	}
}
