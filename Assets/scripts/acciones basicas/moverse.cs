using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
namespace moverse
{

public class mover
{

#region atributos
public Vector2 direccion;
private Control control;
#endregion

public void iniciar_objeto()
{
    control = new Control();
    control.control_gamepad.moverse.performed += ctx => entrada_moverse(ctx);
    control.control_gamepad.moverse.canceled += ctx => salida_moverse(ctx);
}

private void entrada_moverse(UnityEngine.InputSystem.InputAction.CallbackContext l)
{
    direccion = l.ReadValue<Vector2>();
}

private void salida_moverse(UnityEngine.InputSystem.InputAction.CallbackContext l)
{
    direccion = Vector2.zero;
}

public void activar_control()
{
    control.control_gamepad.moverse.Enable();
}

public void desactivar_control()
{
    control.control_gamepad.moverse.Disable();
}

}

public class moverse_con_impulso : MonoBehaviour
{




}

}
