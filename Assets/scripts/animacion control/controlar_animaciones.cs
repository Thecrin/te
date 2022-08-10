using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlar_animaciones : MonoBehaviour
{
Queue cola;   //  sirve una cola de prioridades?
List<GameObject> lista;

//public var dato;
public void estado_por_control(Animator controlador,string tacto_pies,string tacto_manos,string tacto_cuerpo,Control[] estado)
{
    
    //controlador es el control de animacion del personaje
    //tacto_pies si el personaje esta pisando
    //tacto manos si el personaje esta agarrando algo
    //tacto_cuerpo si el personaje esta recibiendo algun ataque?
    //direccion es hacia donde se mueve
    //direccion_camara es el movimiento de camara
    switch(tacto_pies)
    {
        case "pisa nada":
    switch(tacto_pies,tacto_manos,tacto_cuerpo,estado[2].control_gamepad.brincar.IsPressed())
    {
        #region animaciones de brincar
////////////////////////////////////////////////////////////////////////
        case("pisa nada","toca nada","no es atacado",false):  //solo cae
    controlador.SetInteger("Estado",2);   //revisa esta despues
        break;

        case("pisa nada","toca nada","no es atacado",true):
    controlador.SetInteger("Estado",2);   //revisa esta despues
        break;
////////////////////////////////////////////////////////////////////////
        case ("pisando","toca nada","no es atacado",true):  //si se mueve el J_isquierdo corre
    controlador.SetInteger("Estado",0);
        break;
////////////////////////////////////////////////////////////////////////
        case ("pisando","toca nada","no es atacado",false):  //si se mueve el J_isquierdo corre
    controlador.SetInteger("Estado",0);
        break;
        #endregion
    }
        break;
        case "pisando":
    switch(tacto_pies,tacto_manos,tacto_cuerpo,estado[1].control_gamepad.moverse.IsPressed())
    {
        #region estados de moverse
        case("pisando","toca nada","no es atacado",true):
        controlador.SetInteger("Estado",1);
        break;
        case("pisando","toca nada","no es atacado",false):
        controlador.SetInteger("Estado",0);
        break;
        #endregion
    }
        break;
    }
        //revisa los queue o list porque la prioridad de animaciones se estan peleando :(
}

}
