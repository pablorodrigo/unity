using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	private Rigidbody2D playerRb;
	private SpriteRenderer playerSprite;
	public float velocidade;
	public bool flipX;

	// Use this for initialization
	void Start () {
		playerRb = GetComponent<Rigidbody2D> ();
		playerSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		// mudar velocidade e direção da movimentação
		if (Input.GetMouseButtonDown (0)) {
			velocidade *= -1;
			flipX = !flipX;
			playerSprite.flipX = flipX;
		}

		playerRb.velocity = new Vector2 (velocidade,playerRb.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D elementoColidido){
		if (elementoColidido.gameObject.CompareTag("espinho")) {
			SceneManager.LoadScene ("gameover");
			Debug.Log ("Morreu");
		}
	}
}
