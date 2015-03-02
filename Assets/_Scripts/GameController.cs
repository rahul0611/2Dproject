using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

	private const int START_TIME = 4;
	//score variables
	public Text scoreText;
	private int score;

	//UI labels
	public Text countDown;

	// countdown timers
	private bool countDownOver;
	private int countDownTime;

	float startTime = 0;
	// Use this for initialization
	void Start () {
		countDownOver = false;
		StartCountDown ();
		startTime = Time.time;
	}
	void StartCountDown(){
	/*	while (!countDownOver) {
			countDownTime = (int)startTime + START_TIME - (int)Time.time;
			if (countDownTime <= 0){
				countDown.text = "";
				countDownOver = true;
			}*/
		
		}
	


	
	// Update is called once per frame
	void Update () {
	
	}
}
