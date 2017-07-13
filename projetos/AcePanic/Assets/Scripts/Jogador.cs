using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jogador : MonoBehaviour {

	private int pontuacao = 0;
	[SerializeField]private Text campoTexto; 

	// Use this for initialization
	void Start () {
		pontuacao = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//pontuacao++;
		//campoTexto.text = "Pontuação: " + pontuacao;
	}

	public void SetPontuacao(){
		pontuacao++;
		campoTexto.text = "Pontuação: " + pontuacao;
	}
}
