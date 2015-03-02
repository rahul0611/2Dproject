using UnityEngine;
using System.Collections;

public class AsteroidRandom : MonoBehaviour {

	private Vector3 start;
	private float newPosition = -10f ;
	public float speed = 1.0f;
	public float distance = 5f;
	public GameObject[] random;
	public float timeLeft = 0f;
	public float startTime = 0f;
	public float waitTime = 2f;
	// Use this for initialization
	void Start () {
		start = this.transform.position;
	}
	void RandomObject(){
		int item = Random.Range (0, 2);
		GameObject obj = Instantiate (random[item]) as GameObject;
		obj.transform.position = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		newPosition = Mathf.PingPong (Time.time * speed, distance) - (distance/2);
		transform.position = new Vector3 (newPosition, start.y, start.z);
		
		timeLeft = Time.time - startTime;
		
		if(timeLeft >= waitTime){
			startTime = Time.time;
			timeLeft = 0;
			RandomObject();
			
		}
	}
}
