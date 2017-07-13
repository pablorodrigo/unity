using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeEspinhos : MonoBehaviour {

	[SerializeField]private GameObject espinho;
	Vector3 posicaoDoGerador;
	private float tempoDeCriacao = 2f;
	private float momentoDaUltimaGeracao;
	// Use this for initialization
	void Start () {
		//posicaoDoGerador = this.transform.position;
		//Instantiate (espinho, posicaoDoGerador, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		GeraInimigo ();
	}


private void GeraInimigo(){
		float tempoAtual = Time.time;
		if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao) {
			momentoDaUltimaGeracao = tempoAtual;
			Vector3 posicaoDoGerador = this.transform.position;
			Instantiate (espinho, posicaoDoGerador, Quaternion.identity);
		
		}

	}


}
