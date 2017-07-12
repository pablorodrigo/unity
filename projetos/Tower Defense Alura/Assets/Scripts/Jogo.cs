using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour {

	[SerializeField]private GameObject torrePrefab;

	[SerializeField]private GameObject gameOver;

	[SerializeField]private Jogador jogador;

	void Start(){
	
		gameOver.SetActive (false);
	
	}

	void Update(){

		if (JogoAcabou ()) {
			gameOver.SetActive (true);
		} else {

			if (CliclouComBotaoPrimario ()) {
				ConstroiTorre ();
			}
		}
	}

	private bool JogoAcabou(){
		return !jogador.EstaVivo ();
	}



	private bool CliclouComBotaoPrimario(){
	
		//botao primario
		return Input.GetMouseButtonDown (0);

	}

	private void ConstroiTorre(){
		Debug.Log(Camera.main);
		Debug.Log(Input.mousePosition);
		Vector3 posicaoDoClique = Input.mousePosition;

		RaycastHit elementoAtingidoPeloRaio = DisparaRaioDaCameraAteUmPonto (posicaoDoClique);

		if (elementoAtingidoPeloRaio.collider != null) {
		
			Vector3 posicaoDeCriacaoDaTorre = elementoAtingidoPeloRaio.point;
			Instantiate(torrePrefab, posicaoDeCriacaoDaTorre, Quaternion.identity);
		}

	}

	private RaycastHit DisparaRaioDaCameraAteUmPonto(Vector3 pontoInicial){
		Ray raio = Camera.main.ScreenPointToRay(pontoInicial);
		RaycastHit elementoAtingidoPeloRaio;
		float comprimentoMaximoDoRaio = 500.00f;
		//forcar alemento a passar por referencia out
		Physics.Raycast (raio, out elementoAtingidoPeloRaio ,comprimentoMaximoDoRaio);

		return elementoAtingidoPeloRaio;
	}

	public void RecomecaJogo(){
		Application.LoadLevel (Application.loadedLevel);
	}

}
