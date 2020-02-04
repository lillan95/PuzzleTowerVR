using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {

	public GameObject DestroyedObject;


	
	void OnCollisionEnter( Collision collision ) {
		Debug.Log (collision.impactForceSum.magnitude);


		if( collision.relativeVelocity.magnitude > 6f) {
		DestroyIt();
		}
	}
	
		void DestroyIt(){
		if(DestroyedObject) {
			Instantiate(DestroyedObject, transform.position, transform.rotation);
		}
		Destroy(gameObject);

	}
}