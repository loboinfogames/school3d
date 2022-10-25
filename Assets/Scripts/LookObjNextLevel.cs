using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LookObjNextLevel : MonoBehaviour
{
    public AudioSource sound;
    public GameObject toEnable;
    public Rigidbody rdb;
    public Vector3 force;
    public string CENAESCOLHIDA;
    //funcao que é chamada depois de um tempo olhando
    public void ButtonAction()
    {
        SceneManager.LoadScene(CENAESCOLHIDA);
        //toca o som escolhido
        if (sound)
        {
            sound.Play();
        }
        //habilita gameobjec selecionado
        if (toEnable)
        {
            toEnable.SetActive(true);
        }
        //adiciona uma força no objeto selecionado
        if (rdb)
        {
            rdb.AddForce(force, ForceMode.Impulse);
        }
    }

    //se acontece uma colisao toca o som
    private void OnCollisionEnter(Collision collision)
    {
        if (sound)
        {
            
            sound.Play();
            
        }
    }
    /*funcao que é chamada pelo player
    public void ButtonAction()
    {
        Invoke(functiontocall, 0);
    }

    public void LoadGame2()
    {
        //carrega uma cena
        SceneManager.LoadScene("level2");
    }*/

}
