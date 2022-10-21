using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
	[Header("Nome da cena a ser carregada")]
	public string cenaACarregar;
	[Space(20)]
	public Texture texturaFundos;
	public Texture barraDeProgresso;
	public string textoLoad = "Progresso do carregamento:";
	public Color corDoTexto = Color.white;
	public Font Fonte;
	[Space(20)]
	[Range(0.5f,3.0f)]
	public float tamanhoDoTexto = 1.5f;
	[Range(1,10)]
	public int larguraDaBarra = 8;
	[Range(1,10)]
	public int alturaDaBarra = 2;
	[Range(-4.5f,4.5f)]
	public float deslocarBarra = 4;
	[Range(-8,4)]
	public float deslocarTextoX = 2;
	[Range(-4.5f,4.5f)]
	public float deslocarTextoY = 3;

	private bool mostrarCarregamento = false;
	private int progresso = 0;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			
		}
	}
	public void carregar(string cena){
		cenaACarregar = cena;
		StartCoroutine(CenaDeCarregamento(cenaACarregar));
	}

	IEnumerator CenaDeCarregamento (string cena){
		mostrarCarregamento = true;

		AsyncOperation carregamento = SceneManager.LoadSceneAsync (cena);/* Application.LoadLevelAsync (cena);*/
		while (!carregamento.isDone) {
			progresso = (int)(carregamento.progress*100);
			yield return null;
		}
	}

	void OnGUI (){
		if (mostrarCarregamento == true) {
			GUI.contentColor = corDoTexto;
			GUI.skin.font = Fonte;
			GUI.skin.label.fontSize = (int)(Screen.height/50*tamanhoDoTexto);
			//TEXTURA DE FUNDO
			GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), texturaFundos);

			//TEXTO DE CARREGAMENTO
			float deslocXText = (Screen.height/10)*deslocarTextoX;
			float deslocYText = (Screen.height/10)*deslocarTextoY;
			GUI.Label(new Rect(Screen.width/2 + deslocXText, Screen.height/2 + deslocYText, Screen.width, Screen.height),textoLoad + " " + progresso + "%");  

			//BARRA DE PROGRESSO
			float largura = Screen.width*(larguraDaBarra/10.0f);
			float altura = Screen.height/50*alturaDaBarra;
			float deslocYBar = (Screen.height/10)*deslocarBarra;
			GUI.DrawTexture(new Rect(Screen.width/2 - largura/2, Screen.height/2 - (altura/2) + deslocYBar, largura*(progresso/100.0f), altura), barraDeProgresso);                                    
		}
	}
}
