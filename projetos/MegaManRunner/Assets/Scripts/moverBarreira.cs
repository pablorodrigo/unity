using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverBarreira : MonoBehaviour {

	public float velocidade;
	private float x;
	[SerializeField] GameObject player;
	private  bool pontuado;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player") as GameObject;
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

		if(x<player.transform.position.x && !pontuado ){
			pontuado = true;
			PlayerController.pontuacao++;
		}

	}
}
