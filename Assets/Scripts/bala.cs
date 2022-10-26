using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
 
    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.name == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(gameObject, 5);
        }
    }   
    /*void Awake()
    {
        Destroy(gameObject, 5);
    }*/
}
