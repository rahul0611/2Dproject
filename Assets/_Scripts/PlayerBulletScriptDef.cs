using UnityEngine;
using System.Collections;

using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBulletScriptDef : MonoBehaviour {
	
	public float speed =10;
	public GameObject expo;




	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.right.normalized * speed;
		audio.Play ();


	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll )
	{

		Debug.Log ("#################");


		if (coll.gameObject.tag.Equals ("Enemy")) 
		{

			Debug.Log ("################# Enemy");
			GameObject.FindGameObjectWithTag("scoreValue").GetComponent<Text>().text = int.Parse(GameObject.FindGameObjectWithTag("scoreValue").GetComponent<Text>().text) + 100 +""; 

			Destroy(coll.gameObject);
			Debug.Log ("################# One");

			Debug.Log ("################# Two");
			Destroy(this.gameObject);
			Debug.Log ("################# Three");
			Instantiate(expo,this.transform.position,Quaternion.identity);

			 



		}

		if (coll.gameObject.tag.Equals ("EnemyBullet")) 
		{
			Debug.Log ("################# EnemyBu;llrt");

			Destroy(coll.gameObject);
			GameObject.FindGameObjectWithTag("scoreValue").GetComponent<Text>().text = int.Parse(GameObject.FindGameObjectWithTag("scoreValue").GetComponent<Text>().text) + 50 +""; 
			 
			Destroy(this.gameObject);

		}

		if (coll.gameObject.tag.Equals ("Asteroid")) 
		{
			 
			Debug.Log ("################# Asteroid");

			Destroy(gameObject);
			Debug.Log ("################# Asteroid Done!");

		}
	}
}
