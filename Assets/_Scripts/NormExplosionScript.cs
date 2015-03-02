using UnityEngine;
using System.Collections;

public class NormExplosionScript : MonoBehaviour {

	void OnAnimationFinish()
	{
		audio.Play ();
		Destroy (gameObject);
	}
}
