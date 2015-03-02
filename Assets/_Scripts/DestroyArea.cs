using UnityEngine;
using System.Collections;

public class DestroyArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag.Equals ("PlayerBullet")) 
		{
			Destroy(coll.gameObject);
		}

		if (coll.gameObject.tag.Equals ("EnemyBullet")) 
		{
			Destroy(coll.gameObject);
		}

		if (coll.gameObject.tag.Equals ("Asteroid")) 
		{
			Destroy(coll.gameObject);
		}

		if (coll.gameObject.tag.Equals ("Enemy")) 
		{
			Destroy(coll.gameObject);
		}
	}
}
