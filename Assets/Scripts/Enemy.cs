using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Transform Alvo;
    public ControleJogo CJ;

    void Start()
    {
        Alvo = GameObject.Find("Player").transform;
       //CJ = GameObject.Find("Canvas").GetComponent<ControleJogo>();
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            //Destroy(gameObject);
            //CJ.QuantidadeMorte += 1;
        }
    }
}
