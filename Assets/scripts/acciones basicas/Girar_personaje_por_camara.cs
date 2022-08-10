using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar_personaje_por_camara :MonoBehaviour
{
    //lafuncion girar aun no funciona bien :(
    public void girar(Vector2 direccion,Transform personaje)
    {
        checked{
        switch(direccion.x,direccion.y)
        {
            case (<0,>=0):
                personaje.localRotation = Quaternion.Euler(0.0f,System.MathF.Atan(direccion.x/direccion.y) * (180.0f/System.MathF.PI) ,0.0f);
            break;
            case (>=0,>=0):
                personaje.localRotation = Quaternion.Euler(0.0f,System.MathF.Atan(direccion.x/direccion.y) * (180.0f/System.MathF.PI) ,0.0f);
            break;
            case (<0,<0):
                personaje.localRotation = Quaternion.Euler(0.0f,-System.MathF.Atan(direccion.x/direccion.y) * (-180.0f/System.MathF.PI)+180.0f,0.0f);
            break;
            case (>=0,<=0):
                personaje.localRotation = Quaternion.Euler(0.0f,-System.MathF.Atan(direccion.x/direccion.y) * (-180.0f/System.MathF.PI)-180.0f,0.0f);
            break;
        }
        }
    }
    public void girar_personaje(Transform personaje,Vector2 direccion)
    {
        #region girar personaje ante camara
        if(direccion != Vector2.zero)
            personaje.localRotation = Camara_control.camara.localRotation;
            //personaje.localRotation = new Quaternion(personaje.localRotation.x,Camara_control.camara.localRotation.y,personaje.localRotation.z,personaje.localRotation.w);
            //personaje.localRotation = new Quaternion(personaje.localRotation.x,Camara_control.camara.localRotation.y,personaje.localRotation.z,personaje.localRotation.z);
            else
            return;
        #endregion
    }
}
