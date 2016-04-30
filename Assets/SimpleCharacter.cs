using UnityEngine;
using System.Collections;

public class SimpleCharacter : MonoBehaviour {
	public float speed = 3f;
	public CharacterController MyController;
	// Update is called once per frame
	void Update () {

		Vector3 myVector = new Vector3(0, 0, 0);
		//get input from player
		myVector.x = Input.GetAxis("Horizontal");
		myVector.z = Input.GetAxis("Vertical");
		myVector *= speed;
		//use input to move the character around

		MyController.SimpleMove(myVector);
	}
}
