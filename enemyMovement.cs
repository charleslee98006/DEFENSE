using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("gameManager").GetComponent<manager>().gameStarted){
			transform.Translate(new Vector3(-1,0,0) * Time.deltaTime);
		}
	}
}
