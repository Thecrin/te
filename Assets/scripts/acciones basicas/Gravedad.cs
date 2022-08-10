using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour
{
    //esta clase modificara la gravedad del personaje

    #region atributos principales
    private Vector3 direccion_gravedad,angulos;
    private float velocidad = 200,velocidad_camara = 100;
    private float fuerza_gravedad;
    private float cambio,cambio_personaje;
    //private Vec; 
    public static bool activar,activar_personaje;
    #endregion

    #region funciones principales

    public void cambiar_gravedad(Vector2 direccion) //direccion es hacia donde se mueve
    {
        switch(direccion.x,direccion.y)
        {
            
            case (0,0):
            angulos = new Vector3(180,0,0);
            direccion_gravedad = -direccion_gravedad;
            Debug.Log(direccion_gravedad);
            activar = activar_personaje = true;   
            break;
            case (>0,>0):
            direccion_gravedad.z =direccion_gravedad.z+90;
            direccion_gravedad = new Vector3(direccion_gravedad.z,0,0).normalized *fuerza_gravedad;
            Debug.Log(direccion_gravedad);
            activar = activar_personaje = true;
            break;
        }
    }

    public void atraccion_gravedad(Rigidbody impulso)
    {
        impulso.AddForce(direccion_gravedad,ForceMode.Force);
    }

    public void iniciar_atributos(Vector3 gravedad)
    {
        fuerza_gravedad = System.MathF.Abs(gravedad.y);
        activar = activar_personaje = false;
        cambio = cambio_personaje = 0;
        direccion_gravedad = gravedad.normalized * fuerza_gravedad;
    }

    public void girar_camara(Transform camara,Vector2 direccion)
    {

        switch(direccion.x,direccion.y)
        {
            case (0,0):
        if(activar)
        {
        camara.Rotate(-1,0,0);
        cambio++;
        if(cambio >= 90)
        {
        activar = false;
        //camara.localRotation = Quaternion.Euler(-180,0,0);
        }
        }
        else
        {
            activar = false;
            cambio =0;
        }
            break;

            case (>0,>0):
        if(activar)
        {
        camara.Rotate(0,0,1);
        cambio++;
        if(cambio >= 90)
        {
        activar = false;
        //camara.localRotation = Quaternion.Euler(-180,0,0);
        }
        }
        else
        {
            activar = false;
            cambio =0;
        }
            break;

        }
    }

public void girar_personaje(Transform personaje,Vector2 direccion)
{
    switch(direccion.x,direccion.y)
    {
        case(0,0):
    if(activar_personaje)
    {
        personaje.Rotate(Time.deltaTime * velocidad,0,0);
        cambio_personaje = cambio_personaje + Time.deltaTime*velocidad;
        if(cambio_personaje >= 180)
        activar_personaje = false;
    }
    else
    {
        activar_personaje = false;
        cambio_personaje = 0;
    }
        break;

        case(>0,>0):
    if(activar_personaje)
    {
        personaje.Rotate(0,0,Time.deltaTime * velocidad);
        cambio_personaje = cambio_personaje + Time.deltaTime*velocidad;
        if(cambio_personaje >= 90)
        activar_personaje = false;
    }
    else
    {
        activar_personaje = false;
        cambio_personaje = 0;
    }
        break;
    }

}

    #endregion
}
