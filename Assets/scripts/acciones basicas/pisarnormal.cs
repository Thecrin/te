using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisarnormal : MonoBehaviour
{
//esta clase tendra las funciones basicas de pisar en la normal de una superficie

public static void ajustar_angulo(Transform personaje,Vector3 gravedad)
{
    RaycastHit hit;
    Vector3 nueva_posicion = new Vector3(personaje.position.x,personaje.position.y,personaje.position.z );

    if(Physics.Raycast(nueva_posicion,Vector3.down,out hit,2))
    {
        if(hit.collider.gameObject.tag == "suelo")
        {
    personaje.localRotation = Quaternion.FromToRotation(Vector3.up,hit.normal);
    gravedad = -hit.normal * 9.81f;
        }
    }
}

}
