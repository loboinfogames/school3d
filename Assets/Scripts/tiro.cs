using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    public Rigidbody obj_shooter; //prefab bala(bullet)
    public Transform pos_origem; //posição de origem
    public float speed = 1000;
    

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //botão de tiro configurado, Space
        {
            //Debug.Log("Atirando");
            Rigidbody shooter_instance;
            shooter_instance = Instantiate(obj_shooter, 
                pos_origem.position, pos_origem.rotation) 
                as Rigidbody;

            shooter_instance.AddForce(pos_origem.forward * speed);
        }

    }

}
