using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{


		public 	Text countdownText;

		// Use this for initialization
		void Start ()
		{
	
		}

		float timeVal = 4.0f;
		// Update is called once per frame
		void Update ()
		{
	
				if (countdownText != null) {
			
						timeVal -= Time.deltaTime;
			
						if (timeVal <= 0) {
				
								Destroy (countdownText);
						}
			
						countdownText.text = timeVal + "";
				} else {
						Application.LoadLevel ("scene1");
		
				}
		}
}
