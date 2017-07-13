using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspinhoCaindo : MonoBehaviour {

	private Rigidbody2D espinhoRb;
	public int atritoMinimo;
	public int atritoMaximo;
	private int atrito;
	public Vector3 posicao;
	public GameObject espinhoPrefab;
	// Use this for initialization
	void Start () {
		espinhoRb = GetComponent<Rigidbody2D> ();
		atrito = Random.Range (atritoMinimo, atritoMaximo);
		espinhoRb.drag = atrito; 

		posicao = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//quando espinho sair da tela, um novo é respaw
	/*void OnBecameInvisible(){
		//Instantiate (espinhoPrefab, posicao, Quaternion.identity);
		//Destroy (this.gameObject);
	}


	void OnCollisionEnter2D(Collision2D elementoColidido){
		if (elementoColidido.gameObject.CompareTag("chaobase")) {
			//Destroy (this.gameObject);
		}
	}*/

}
