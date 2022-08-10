using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_control : MonoBehaviour
{

#region atributos camara
public static Transform camara;
[SerializeField] Transform personaje;
public static Vector2 direccion;
public Vector2 velocidad_camara;
#endregion

private void LateUpdate()
{
    transform.Rotate(0.0f,velocidad_camara.x *direccion.x * Time.deltaTime,0.0f);
    transform.localPosition = personaje.position;
    camara = transform;
}


}
