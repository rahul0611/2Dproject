using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	public GameObject enemyBullet;
	public GameObject expo;
	// Use this for initialization
	IEnumerator Start () {
		while (true) 
		{
			Instantiate(enemyBullet, this.transform.position,Quaternion.identity);
			yield return new WaitForSeconds(1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(-1,0) * 5;
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag.Equals ("Player")) 
		{
			coll.gameObject.renderer.enabled = false;
			Instantiate(expo,this.transform.position,Quaternion.identity);
			//Destroy(coll.gameObject);
			Destroy (this.gameObject);
		}

	}
	
}
