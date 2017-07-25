using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {

	[SerializeField] UnityEngine.UI.Text pontos;
	[SerializeField] UnityEngine.UI.Text recorde;

	// Use this for initialization
	void Start () {

		pontos.text = PlayerPrefs.GetInt ("pontuacao").ToString();
		recorde.text = PlayerPrefs.GetInt ("recorde").ToString();

	}

}
