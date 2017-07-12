using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour {

	//pegar objeto prefab
	public GameObject projetilPrefab;
	public float tempoRecarga = 1f;
	private float momentoUltimoDisparo;
	public double raioDeAlcance;

	// Use this for initialization
	void Start () {
		
	}

	private void atira (Inimigo inimigo){
		// contar o tempo decorrete tesdo inicio do jogo
		float tempoAtual = Time.time;
		if(tempoAtual > momentoUltimoDisparo + tempoRecarga){
			momentoUltimoDisparo = tempoAtual;
		//procura um gameObject especifico
		GameObject pontoDisparo = this.transform.Find ("CanhaoTorre/pontoDisparo").gameObject;
		//pega a posicao desse objetdo
		Vector3 posicaoPontoDisparo = pontoDisparo.transform.position;
		// inicia o projetil na posicao pesquisada
			GameObject projetoObject = (GameObject)  Instantiate (projetilPrefab,posicaoPontoDisparo,Quaternion.identity);
		//o alvo agora é esse cara ae
			Missil missil = projetoObject.GetComponent<Missil>();
			missil.DefineAlvo (inimigo);

		}
	}
	
	// Update is called once per frame
	void Update () {
		Inimigo alvo = EscolhaAlvo ();

		if (alvo != null) {
			//chama o metodo de atirar e é criado o missel
			atira (alvo);
		}
			
	}

	private Inimigo EscolhaAlvo(){
		GameObject[] inimigos = GameObject.FindGameObjectsWithTag ("Inimigo");
		foreach (GameObject inimigo in inimigos) {
		
			if (EstaNoRaioDeAlcance (inimigo)) {
			
				return inimigo.GetComponent<Inimigo> ();
			
			}
				
		}
		return null;
	}

	private bool EstaNoRaioDeAlcance(GameObject inimigo){
	
		Vector3 posicaoDaTorre =	this.transform.position;

		Vector3 posicaoDaTorreNoPlano = Vector3.ProjectOnPlane(posicaoDaTorre,Vector3.up);

		Vector3 posicaoDoInimigo = inimigo.transform.position;
		Vector3 posicaoDoInimigoNoPlano = Vector3.ProjectOnPlane(posicaoDoInimigo,Vector3.up);

		//calcular distancia
		float distanciaParaInimigo = Vector3.Distance (posicaoDaTorreNoPlano,posicaoDoInimigoNoPlano);

		return distanciaParaInimigo <= raioDeAlcance;
	
	}

}
