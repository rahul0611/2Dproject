using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainControllerScript : MonoBehaviour {

	public Transform playerrespawn = GameObject.FindGameObjectWithTag("PlayerRespawn").transform;

	public GameObject playerObj;

	public GameObject player1;


	//REMAINING SECONDS VARIABLE
	private int remainingSeconds;
	
	//ENEMIES DESTROYED VARIABLE
	private int enemiesDestroyed;
	
	//FIRE VARIABLES
	private float nextFire;

	private float fireRate;
	
	//public GameObject Shot;
	//public Transform Cannon;
	
	//SCORE VARIABLES
	public Text scoreText;
	private int score;
	
	//UI VARIABLES
	 public Text fuelCount;
	
	//public Text enemiesLeftText;
	public Text countdownText;


	public Text lifeLine;


	//COUNTDOWN TIMERS
	private bool countdownOver;
	private int levelStartingSeconds;

	// Use this for initialization
	void Start () {
		UpdateScore();
		
		StartLevel();
	}

	void UpdateScore()
	{
		scoreText.text = score.ToString();
	}

	float levelStartTime = 0;

	void StartLevel()
	{
	/*	levelStartTime = Time.time;

		//Initialize Remaining Seconds
		remainingSeconds = 4;

		levelStartingSeconds = (int)levelStartTime + START_TIME - (int)Time.time;
		countdownText.text = levelStartingSeconds.ToString();
		
		countdownOver = false;
		StartCountdown();

		InvokeRepeating("SpawnEnemy", START_TIME, 3);
		*/


	}

	void StartCountdown()
	{
		countdownText.text = levelStartingSeconds.ToString();
	}

	void SpawnEnemy()
	{

	}

	float timeVal = 4.0f;
	// Update is called once per frame

	float fuelTime = 3.0f;
	void Update () {

		if (countdownText != null) {
				
			timeVal -= Time.deltaTime;
				
			if(timeVal<=0){

				Destroy(countdownText);
			}

			countdownText.text = timeVal+"";
		}

		

		if(fuelCount!= null){

			fuelTime -= Time.deltaTime;

			if(fuelTime <= 0){

				fuelCount.text=int.Parse(fuelCount.text)-1+"";

				fuelTime=3.0f;
			}

			if(int.Parse(fuelCount.text) <=0 ){

				Application.LoadLevel("First_Scene");

			}

		}


		if (!playerObj.renderer.enabled) {



			Debug.Log ("PlayerDead");
			Instantiate(player1, playerrespawn.position, Quaternion.identity);	
			playerObj.renderer.enabled = true;

		}


			
	}
}
