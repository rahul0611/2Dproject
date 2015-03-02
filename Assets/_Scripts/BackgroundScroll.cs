using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Repeat (Time.time * speed, 1);


		Vector2 offset = new Vector2 (x , 0);
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);
	}
}
