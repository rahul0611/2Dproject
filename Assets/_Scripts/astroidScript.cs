using UnityEngine;
using System.Collections;

public class astroidScript : MonoBehaviour {

	private Vector3 cent;
	public GameObject expo;
	public int rotSpeed = 90;
	// Use this for initialization
	void Start () {
		cent = collider2D.bounds.center;
		rigidbody2D.velocity = new Vector2(-1.5f, -1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround (cent, Vector3.back, rotSpeed * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.tag.Equals ("Player") || coll.gameObject.tag.Equals("Enemy")) 
		{

			Destroy(coll.gameObject);
			Destroy(this.gameObject);
			Instantiate(expo,this.transform.position,Quaternion.identity);
		}
	}
}
