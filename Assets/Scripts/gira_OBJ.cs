using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gira_OBJ : MonoBehaviour
{
    public float SaiAndando;
    public float RotY, RotX, RotZ;

   // public float smooth;
   // public float tiltAngle;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.left * SaiAndando * Time.deltaTime);

        transform.Rotate( 0,10 * Time.deltaTime * RotY, RotX);
        


        /*
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);*/

    }
}
