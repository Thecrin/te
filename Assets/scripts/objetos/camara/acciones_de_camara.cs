using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acciones_de_camara : MonoBehaviour
{
    [SerializeField] GameObject personaje_a_seguir;
    private Vector3 distania_camara;

    private void Update()
    {
        Vector3 angulo = transform.position;
        transform.localRotation = Quaternion.FromToRotation(Vector3.up,-angulo);
    }
}
