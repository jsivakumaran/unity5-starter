using UnityEngine;
using System.Collections;

public class SimpleCharacter : MonoBehaviour {
	//variables
	public CharacterController MyController;
	public float speed = 3f;
	public float gravityStrength = 5f;  //gravity constant of earth is 9.8 - you may remember it from high school physics
	public float jumpSpeed = 10f;
	public Transform CameraTransform;
	bool canJump = false;


	// Update is called once per frame
	void Update () {

		Vector3 myVector = new Vector3(0, 0, 0);
		//get input from player
		myVector.x = Input.GetAxis("Horizontal");
		myVector.z = Input.GetAxis("Vertical");
		myVector = myVector * speed * Time.deltaTime;  //Make it move with a particular speed
		//use input to move the character around
		myVector = CameraTransform.rotation * myVector; //rotate input to direction of camera
		float verticalVelocity =MyController.velocity.y - gravityStrength*Time.deltaTime;
		//How do we get the jump key?
		if(Input.GetButtonDown("Jump")){
			//add jumpspeed to vertical velocity
			if(canJump)
				verticalVelocity += jumpSpeed;
		}

		myVector.y = verticalVelocity*Time.deltaTime; //add new speed to old speed to mimick acceleration
		CollisionFlags flags = MyController.Move(myVector); //can use SimpleMove or Move(this is more complex)

		//use flags to determine whether a player can jump or not.  i.e. so that a user doesn't jump while already in the air
		//if on ground 
		//set canJump to true
		if((flags & CollisionFlags.Below) !=0)
			canJump = true;
		else
			canJump = false;
	}
}
