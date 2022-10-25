using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {
	public Texture[] ImagensTrasincao;
	Texture imagem;
	public float TempoTransicao;
	float t;
	int i;
	[Space(10)]
	[Header("Cena que será carregada após a transição")]
	public string Cena;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (i < (ImagensTrasincao.Length)) {
			if (t <= 0) {

				imagem = ImagensTrasincao [i];
				i += 1;
				t = TempoTransicao;
			}

		}
		if (t > 0) {
			t -= Time.deltaTime;
		}

		if (i > (ImagensTrasincao.Length -1 ) && t<=0) {
			SceneManager.LoadScene (Cena);
		}


	}
	void OnGUI(){
		GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), imagem);

	}
}
