using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public float max = 8.0f;
	public GameObject bullet;
	bool shot = true;
	public 	int lifeCount = 2;
	public Text fuelScore;
	

	public static int fuelCount = 50;
	public static int lifelines = 2;
	// Use this for initialization
	void Start () {

		
		}

	// Update is called once per frame
	void Update()
	{
		Clamp ();
	}

	void FixedUpdate () {
		float deltaX = Input.GetAxis ("Horizontal");
		float deltaY = Input.GetAxis("Vertical");
		rigidbody2D.velocity = new Vector2 (deltaX * max, deltaY * max);

		if (Input.GetKey ("space") && shot) 
		{
			StartCoroutine(ShootBullets());
			//audio.Play();
		}
	}

	IEnumerator ShootBullets()
	{
		shot = false;
		Instantiate(bullet, this.transform.position, Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		shot = true;
	}

	void Clamp ()
	{

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		Vector2 pos = transform.position;
	
		pos.x = Mathf.Clamp (pos.x, min.x, max.x);
		pos.y = Mathf.Clamp (pos.y, min.y, max.y);

		transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag.Equals("Fuel"))
		{
			fuelCount += 10;
			Destroy(coll.gameObject);
			Debug.Log(fuelCount);
			fuelScore.text = int.Parse(fuelScore.text)+10 +"";

		}

		if(coll.gameObject.tag.Equals("Asteroid"))
		{

			Debug.Log("Player #######");
			//fuelCount += 10;
			Destroy(coll.gameObject);
			//Debug.Log(fuelCount);
			//fuelScore.text = int.Parse(fuelScore.text)+10 +"";
			
		}
	}

}
