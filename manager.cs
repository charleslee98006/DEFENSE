using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
	public GameObject enemy;
	private bool spawn = false;
	public float spawnTime = 3f;
	public Animator startButton;
	public bool gameStarted;
	// Use this for initialization
	void Start () {
		gameStarted = false;
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
//	void wait(float duration){
//		Debug.Log("Start Wait() function. The time is: "+Time.time);
//		Debug.Log( "Float duration = "+duration);
//		if (Time.time > duration) {
//			spawn = true;
//		} //Wait
//		Debug.Log("End Wait() function and the time is: "+Time.time);
//	}
	void Spawn(){
		if(gameStarted){
			Instantiate (enemy, new Vector3 (21, 1, (Random.value*10)), Quaternion.identity);
		}
	}
	public void OpenSettings()
	{
		gameStarted = true;
		startButton.SetBool("startClick", true);

	}
}
