using System.Collections;
using UnityEngine;

public class Wander03 : MonoBehaviour{
    public float moveSpeed; 
    public Transform target;
void Update(){
   
}


void Wander(){
     print("Wolf is Wandering!");
    transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
    int randomNum = Random.Range(0,360);
    Vector3 fwd = transform.TransformDirection(Vector3.forward);
    RaycastHit hit;


    Debug.DrawRay(transform.position,fwd*3,Color.red);

    if(Physics.Raycast(transform.position,fwd,out hit,3)){

        if(hit.collider.tag == "Wall"){
            transform.Rotate(0,randomNum,0);
        }
    }

}

void Follow(){
     print("Wolf is Following!");
    transform.LookAt(target);
	transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
}

void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name == "Player"){
			Follow();
		}        
        else{
           
            Wander();
        }

	}

} 