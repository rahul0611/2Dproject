﻿using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	private Vector3 start;
	private float newPosition = -10f ;
	public float speed = 1.0f;
	public float distance = 3f;
	public GameObject random;
	public float timeLeft = 0f;
	public float startTime = 0f;
	public float waitTime = 3f;
	// Use this for initialization
	void Start () {

		start = this.transform.position;


		//obj.transform.position = transform.position;
	}
	void RandomObject(){

		GameObject obj = Instantiate (random) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		newPosition = Mathf.PingPong (Time.time * speed, distance) - (distance/2);
		transform.position = new Vector3 (start.x, newPosition, start.z);

		timeLeft = Time.time - startTime;

		if(timeLeft >= waitTime){
			startTime = Time.time;
			timeLeft = 0;
			RandomObject();
		
		}
	}
}
