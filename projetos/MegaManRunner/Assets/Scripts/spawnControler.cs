﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnControler : MonoBehaviour {

	[SerializeField]private GameObject barreiraPrefab;
	//intervalo do spawn
	public float rateSpawn;
	private float currentTime;
	private int posicao;
	private float y;
	public float posicaoA;
	public float posicaoB;

	// Use this for initialization
	void Start () {
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if(currentTime >= rateSpawn){
			currentTime = 0;
			posicao = Random.Range (1,100);
			if (posicao > 50) {
				y = posicaoA;
				//y = -0.04f;
			}else {
				y = posicaoB;
				//y = 0.6f;
			}

			GameObject tempPrefab = Instantiate (barreiraPrefab) as GameObject;
			tempPrefab.transform.position = new Vector3 (transform.position.x,y,tempPrefab.transform.position.z);
		}
	}
}
