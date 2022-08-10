using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brincar : MonoBehaviour
{
    CollectionBase espartanos_frikis;
    //poner @"cadena\n"   hace que se ignoren los caracteres especiales como \n
    sbyte datosss;
    ///<doc>
    ///<code>   //trata el comentario de abajo como si fuera codigo
    ///Rigidbody datos; 
    /// </code>
    ///</doc>
    ///esta es una funcion para los atributod de brincar    comentario xml
    //nunca habra funciones en c# todos son metodos
/// <summary> esse lol</summary>>
private Control control;
internal TexGenMode lal;
private float intensidad;
public Vector2 impulso;
public Vector3 direccion;
public void brinca(Rigidbody impulso)
{
    impulso.AddRelativeForce(-direccion,ForceMode.Impulse);
}

public void cae(Rigidbody impulso)
{
    this.rar(); //que hace esta?
    impulso.AddRelativeForce(direccion * intensidad,ForceMode.Impulse);
}

public void rar(params int[] var)   //hacer esto hace que la funcion llace cualquier numero de parametros
{

}
}


