using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	//public float speed = 10f;
	//public float rotationSpeed = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.position += new Vector3 (0, 0, 1);		
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			transform.position += new Vector3 (-1, 0, 0);
		}		
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.position += new Vector3 (1, 0, 0);
		}

		//float translation = Input.GetAxis("Vertical") * speed;
		//float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		//translation *= Time.deltaTime;
		//rotation *= Time.deltaTime;
		//transform.Translate(0, 0, translation);
		//transform.Rotate(0, rotation, 0);
	}
}
