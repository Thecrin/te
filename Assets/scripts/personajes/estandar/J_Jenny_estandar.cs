using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_Jenny_estandar : MonoBehaviour
{
    #region atributos de jenny
    [SerializeField] Animator jenny;
    public Vector2 velovidad,velocidad_camara;
    [SerializeField] Rigidbody impulso;
    [SerializeField] Transform personaje,camara;
    private Control control;
    private Gravedad cambiar_gravedad = new Gravedad();
    private Vector2 direccion;
    public LayerMask mascara;
    private float anguloY;
    private Girar_personaje_por_camara girar = new Girar_personaje_por_camara();
    #endregion
    
    
    #region funciones monovehabiour
    private void Awake()
    {
        #region buscar componentes
        control = new Control();  
        #endregion

        #region acciones de control
        control.control_gamepad.moverse.performed += ctx => accion_mover(ctx);
        control.control_gamepad.Camara.performed += ctx => Camara_control.direccion = ctx.ReadValue<Vector2>();
        control.control_gamepad.gravedad.performed += ctx => cambiar_gravedad.cambiar_gravedad(direccion);
        #endregion  

        #region salidas de control
        control.control_gamepad.moverse.canceled += ctx => salida_mover(ctx);
        control.control_gamepad.Camara.canceled += ctx => Camara_control.direccion = Vector2.zero;
        #endregion
    }
    
    void Start()
    {
        cambiar_gravedad.iniciar_atributos(Physics.gravity);
    }

    // Update is called once per frame
    void Update()
    {
        if(direccion != Vector2.zero)
        jenny.SetInteger("Estado",1);
        else
        jenny.SetInteger("Estado",0);

        rayo(new Vector3(0.0f,0.02f,0.4f));
    }

    private void FixedUpdate()
    {
        //rayo(new Vector3(0.0f,0.02f,0.0f));
        //impulso.velocity = new Vector3(direccion.x * velovidad.x* (float)System.Math.Cos(transform.localRotation.eulerAngles.y* (System.MathF.PI/180)),impulso.velocity.y,direccion.y * velovidad.y * (float)System.Math.Cos(transform.localRotation.eulerAngles.y * (System.MathF.PI/180)));
        impulso.velocity = new Vector3(personaje.forward.x * (direccion.x * System.MathF.Sign (direccion.x)) * velovidad.x,impulso.velocity.y,personaje.forward.z * (direccion.y * System.MathF.Sign(direccion.y))*velovidad.y);
        cambiar_gravedad.atraccion_gravedad(impulso);


    }

    private void LateUpdate()
    {
        cambiar_gravedad.girar_camara(Camara_control.camara,direccion);
        cambiar_gravedad.girar_personaje(transform,direccion);
        //camara.Rotate(0.0f,direccion_camara.x * Time.deltaTime * velocidad_camara.x,0.0f);
        girar.girar_personaje(transform,direccion);
        girar.girar(direccion,personaje);
        anguloY = transform.localRotation.y;    //como hacerlo
        pisarnormal.ajustar_angulo(transform,Physics.gravity);
    }

    private void OnEnable() {
        control.control_gamepad.Enable();
    }

    private void OnDisable() {
        control.control_gamepad.Disable();
    }

    #endregion funciones monovehaviour

    #region mis funciones
    private void accion_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = l.ReadValue<Vector2>();
        //jenny.SetInteger("Estado",1);
    }

    private void salida_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = Vector2.zero;
        //jenny.SetInteger("Estado",0);
    }

    private void rayo(Vector3 aumento_punto)
    {
        RaycastHit rayo;
        if(Physics.Raycast(transform.position +aumento_punto,personaje.forward,out rayo,2))
        {
            if(rayo.collider.tag == "roca lia")
            {
                transform.Translate(0.0f,0.5f,0.0f);
            }
        }
    }
    #endregion
}
