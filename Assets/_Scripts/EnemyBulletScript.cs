using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBulletScript : MonoBehaviour {

	public float speed = 8.0f;
	public GameObject expo;
	// Use this for initialization
	void Start () {

		rigidbody2D.velocity = new Vector2 (-2, 0) * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll )
	{
		if (coll.gameObject.tag.Equals ("Player")) 
		{
			//Destroy(coll.gameObject);
			coll.gameObject.renderer.enabled = false;
			Destroy(this.gameObject);
			Instantiate(expo,this.transform.position, Quaternion.identity);
		}
		if (coll.gameObject.tag.Equals ("PlayerBullet")) 
		{
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
		}

		if (coll.gameObject.tag.Equals ("Asteroid")) 
		{
			Destroy(gameObject);
		}
	}
}
