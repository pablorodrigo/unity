using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverBarreira : MonoBehaviour {

	public float velocidade;
	private float x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		// deltaTime = tempo entre frames
		x += velocidade * Time.deltaTime;

		transform.position = new Vector3 (x,transform.position.y,transform.position.z);

		if (x <= -7) {
			Destroy (transform.gameObject);
		}

	}
}
