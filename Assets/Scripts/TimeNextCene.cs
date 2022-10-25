using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeNextCene : MonoBehaviour {
	bool ParedeInvisivel;
	public string ProximaCena;
	[Space(20)]
	[Header("Se for contagem de tempo")]
	public float DuracaoDestaCena;
	[Space(20)]
	[Header("Se for Parede invisivel")]
	public float distanciaPre_carregamento=20;
	float t;
	AsyncOperation op;
	bool ok;
	Transform player;
	// Use this for initialization
	void Start () {
		t = DuracaoDestaCena;
		if (GetComponent<Collider> () != null) {
			ParedeInvisivel = true;
			GetComponent<Collider> ().isTrigger = true;
		}
		if (GameObject.FindGameObjectWithTag ("Player") != null) {
			player = GameObject.FindGameObjectWithTag ("Player").transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if (ParedeInvisivel) {
			var dist = Vector3.Distance (transform.position, player.position);
			print (dist);
			if (dist < distanciaPre_carregamento && op ==null && !ok) {
				op = SceneManager.LoadSceneAsync ( ProximaCena );
				op.allowSceneActivation = false;
				ok = true;
			}
		

		}
		if (!ParedeInvisivel) {
			if (t < (DuracaoDestaCena / 2) && !ok) {
				op = SceneManager.LoadSceneAsync ( ProximaCena );
				op.allowSceneActivation = false;
				ok = true;
			}

			if (t > 0) {
				t -= Time.deltaTime;
			}
			if (t < 0) {
				
				op.allowSceneActivation = true;

			}
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && ParedeInvisivel) {
			if (GameObject.FindObjectOfType<Loading> () != null) {
				GameObject.FindObjectOfType<Loading> ().carregar (ProximaCena);
			} else {
				op.allowSceneActivation = true;
			}
		}
			
	}

}
