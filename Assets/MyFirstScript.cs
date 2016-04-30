using UnityEngine;
using System.Collections;

public class MyFirstScript : MonoBehaviour {
	public string whatToPrint;
	public int numberToPrint =10;
	// Use this for initialization
	void Start () {
		print(whatToPrint + " " + numberToPrint);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
