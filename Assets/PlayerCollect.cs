using UnityEngine;
using System.Collections;

public class PlayerCollect : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		//hit the star object
		print(name + " has been collected");
	}
}
