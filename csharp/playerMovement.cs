using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public bool firegun;
	// Use this for initialization
	void Start () {
		firegun  = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("gameManager").GetComponent<manager>().gameStarted){
			firegun  = true;
			if (Input.GetMouseButtonDown (0)) {
				Debug.Log("fired!");

				this.gameObject.GetComponent<AudioSource>().Play ();
			}
			else{
				firegun  = false;
			}
		}
	}
	void FireOneShot(){
		Vector3 direction = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		
		if (Physics.Raycast (transform.position, direction, 10)) {
			//Debug.DrawLine (Color.cyan);
		}
	}
}
		