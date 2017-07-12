using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour {

	private float velocidade = 10;

	private Inimigo alvo;

	[SerializeField]private int pontosDeDano;

	void Start(){

		//GameObject[] inimigos = GameObject.FindGameObjectsWithTag ("Inimigo");
		//alvo =  GameObject.Find("Inimigo");
		//alvo = inimigos[0];
		AutoDestroiDepoisDeSegundos (3);

	}

	// Update is called once per frame
	void Update () {
		Andar ();
		if (alvo != null) {
			AlteraDirecao ();
		}

	}

	private void Andar(){
		// pego posicao atual do objeto
		Vector3 posicaoAtual =  transform.position;
		// a cada frame desloco o missel em 10 metros
		Vector3 deslocamento = transform.forward * Time.deltaTime * velocidade;
		transform.position = posicaoAtual + deslocamento;
	}

	private void AlteraDirecao(){
		Vector3 posicaoAtualMissel = transform.position;
		Vector3 posicaoAlvo = alvo.transform.position;
		//apontar pra posicao do alvo , mas tem que levantar em conta a posicao do missel
		Vector3 direcaoAlvo = posicaoAlvo - posicaoAtualMissel;
		transform.rotation = Quaternion.LookRotation (direcaoAlvo);
	}

	private void AutoDestroiDepoisDeSegundos(float segundos){
		Destroy (this.gameObject, segundos);
	}

	//emetedo chamado quando um objetec toca em outro
	void OnTriggerEnter (Collider elementoColidido){
	
		// somente destroi quando toca no objeto com tag Inimigo
		if (elementoColidido.CompareTag ("Inimigo")) {
			Destroy (this.gameObject);
			//Destroy (elementoColidido.gameObject);
			Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
			inimigo.RecebeDano (pontosDeDano);
		}


	}

	public void DefineAlvo(Inimigo inimigo){
		
		alvo = inimigo;

	}

}
