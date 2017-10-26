using UnityEngine;
using System.Collections;

public class ChickenAI : MonoBehaviour {
	// public Rigidbody enemy;
	public float moveSpeed;
	public Transform target;
	public Transform chickenPen;
	
	void Start(){
		// chickenPen = GameObject.Find("ChickenPen");
	}
	void OnTriggerStay(Collider other)
	{
		
		if(other.gameObject.name == "Player"){
			Debug.Log("Player has entered chickens trigger");
			transform.LookAt(target);
			transform.Translate(Vector3.back*moveSpeed*Time.deltaTime);
		}
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "Player"){
			/* Destroy(gameObject);*/
			// scoreManager.AddPoints(points);
			transform.position = chickenPen.position;
			transform.rotation = chickenPen.rotation;
		}
	}
}
