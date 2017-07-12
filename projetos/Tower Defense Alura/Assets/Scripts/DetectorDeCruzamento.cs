using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeCruzamento : MonoBehaviour {

	[SerializeField]private Jogador jogador;

	void OnTriggerEnter (Collider collider){

		if (collider.CompareTag ("Inimigo")) {

			Debug.Log ("Chegou no fim");

			Destroy (collider.gameObject);

			jogador.PerdeVida ();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
