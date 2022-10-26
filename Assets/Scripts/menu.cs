using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//acrescentar a biblioteca scnemanagement para as funções abaixo funcionarem

public class menu : MonoBehaviour
{
    public void CenaJogar()
    {
        SceneManager.LoadScene("jogo");
        //carrega a Scene chamada joguinho, colocar o mesmo nome da cena criada
    }
    public void creditos()
    {
        SceneManager.LoadScene("creditos");
        //função para ir para scena creditos
    }
    public void FecharJogo()
    {
        
        //aqui vamos colocar a configuração para fechar o app
    }

}
