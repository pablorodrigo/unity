using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody2D 	playerRigidbody2D;
	public int			forceJumb;
	public Animator 	anime; 
	//private bool			jump;
	public bool 		slide;

	// verifica se ta no chao
	public bool grounded;

	public Transform groudedCheck;

	//verificar layer
	public LayerMask whatISGround;

	//controle slide
	public float slideTemp;
	public float timeTemp;

	//colisor
	//public GameObject colisor;
	public Transform colisor;

	//obstaculo
	//private GameObject barreira;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		//Input.GetButtonDown("Jump")
		if(Input.GetMouseButtonDown (0) && grounded){
			
			playerRigidbody2D.AddForce (new Vector2(0,forceJumb));
			//jump = true;
			if(slide){
				colisor.position = new Vector3 (colisor.position.x,colisor.position.y+0.3f,colisor.position.z);
				slide = false;
			}


		}
		//Input.GetButtonDown("Slide")
		if(Input.GetMouseButtonDown (1) && grounded && !slide){
			colisor.position = new Vector3 (colisor.position.x,colisor.position.y-0.3f,colisor.position.z);
			slide = true;
			timeTemp = 0;

		}
		//ponto do "coliider"
		grounded = Physics2D.OverlapCircle(groudedCheck.position,0.2f,whatISGround);
	

		if (slide) {
			timeTemp += Time.deltaTime;
			if (timeTemp >= slideTemp) {
				colisor.position = new Vector3 (colisor.position.x,colisor.position.y+0.3f,colisor.position.z);
				slide = false;
			}
		}


		anime.SetBool ("jump", !grounded);


		//anime.SetBool ("jump", jump);
		anime.SetBool ("slide", slide);

	}

	void OnTriggerEnter2D(){
	
		Application.LoadLevel ("GameOver");
		//Debug.Log ("Bateu");

	}

}
