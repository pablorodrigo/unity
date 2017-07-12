using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//MonoBehavior - classe que define comportamentos para os game object

public class Inimigo : MonoBehaviour {

	[SerializeField]private int vida;

	// Use this for initialization
	void Start () {
		NavMeshAgent agente = GetComponent<NavMeshAgent>();
		//pegar objetco especifico
		GameObject fimCaminho = GameObject.Find ("FimCaminho");
		// pegar o vetor tridimencional desse objeto
		Vector3 posicaoFimCaminho = fimCaminho.transform.position;
		// destino do objetico inimigo.... do nave mesh ate o fim do caminho
		agente.SetDestination (posicaoFimCaminho);
	}

	public void RecebeDano(int pontoDeDano){

		vida -= pontoDeDano;
		if (vida <= 0) {
			Destroy (this.gameObject);
		}

	} 	

	
	// Update is called once per frame
	void Update () {
		
	}
}
