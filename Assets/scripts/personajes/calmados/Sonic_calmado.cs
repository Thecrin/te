using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonic_calmado : MonoBehaviour
{

    #region atributos sonic
    private Control control;
    private Girar_personaje_por_camara girar = new Girar_personaje_por_camara();
    private Vector2 direccion;
    public Vector2 fuerza;
    [SerializeField] Rigidbody impulso;
    [SerializeField] Transform personaje;
    #endregion

    #region funciones monovehaviour

    private void Awake()
    {
        control = new Control();

        control.control_gamepad.moverse.performed += ctx => entrada_mover(ctx);
        control.control_gamepad.Camara.performed += ctx => entrada_camaras(ctx);

        control.control_gamepad.moverse.canceled += ctx => salida_mover(ctx);  
        control.control_gamepad.Camara.canceled += ctx => salida_camaras(ctx);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate()
    {
        switch(impulso.velocity.z)
        {
            case <10:
        impulso.AddRelativeForce(new Vector3(direccion.x * fuerza.x,0.0f,direccion.y * fuerza.y),ForceMode.Force);
            break;
            case >10:
        impulso.velocity = new Vector3(impulso.velocity.x,impulso.velocity.y,10*direccion.y);
            break;
        }
    }

    private void LateUpdate()
    {
        girar.girar(direccion,personaje);    
        girar.girar_personaje(transform,direccion);
    }

    private void OnEnable()
    {
        control.control_gamepad.Enable();
    }

    private void OnDisable()
    {
        control.control_gamepad.Disable();    
    }

    #endregion

    #region funciones control
    private void entrada_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = l.ReadValue<Vector2>();
    }

    private void entrada_camaras(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        Camara_control.direccion = l.ReadValue<Vector2>();
    }
    
    private void salida_camaras(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        Camara_control.direccion = Vector2.zero;
    }

    private void salida_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = Vector2.zero;
    }
    #endregion
}
