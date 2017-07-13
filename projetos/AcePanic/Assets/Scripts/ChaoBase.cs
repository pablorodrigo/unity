using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoBase : MonoBehaviour {

	[SerializeField]private GeradorDeEspinhos geradorDeEspinhos;
	[SerializeField]private Jogador Jogador;

	void OnCollisionEnter2D(Collision2D elementoColidido){
		Debug.Log ("colidiu");
		if (elementoColidido.gameObject.CompareTag ("espinho")) {

			Destroy (elementoColidido.gameObject);
			Jogador.SetPontuacao ();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
