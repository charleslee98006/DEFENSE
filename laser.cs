using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour {
	LineRenderer line;
	
	void Start () 
	{
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
	}
	void Update () 
	{
		if(GameObject.Find ("FPSController").GetComponent<playerMovement>().firegun)
		{
			Debug.Log ("SHOOT!");
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
	}
	IEnumerator FireLaser()
	{
		line.enabled = true;
		
		while(Input.GetButton("Fire1"))
		{
			Ray ray = new Ray(transform.position, new Vector3(1,0,0));
			RaycastHit hit;
			
			line.SetPosition(0, ray.origin);
			
			if(Physics.Raycast(ray, out hit, 100))
			{
				Debug.Log("HITITTT!");
				line.SetPosition(1, hit.point);
				if(hit.rigidbody.tag== "Enemy")
				{	
					Destroy(hit.transform.gameObject);
					Debug.Log("HITITTT!2");
					hit.rigidbody.AddForceAtPosition(transform.forward* 5, hit.point);
				}
			}
			else
				Debug.Log("NO it!");
				line.SetPosition(1, ray.GetPoint(100));
			
			yield return null;
		}
		
		line.enabled = false;
	}
}