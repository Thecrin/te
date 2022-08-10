using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using moverse;


public class S_Sonic_Estandar : MonoBehaviour
{
    
    #region atributos de sonic
    private bool[] activo = new bool[19];
    private controlar_animaciones controlar_ = new controlar_animaciones();
    private pies pies_sonic = new pies();
    [SerializeField] manos manos_sonic;
    [SerializeField] cabeza cabeza_sonic;
    [SerializeField] Animator sonic;
    [SerializeField] Transform personaje;
    [SerializeField] Rigidbody impulso;
    private Control[] control = new Control[4];
    public Vector2 velocidad,desaceleracion;
    private const float velocidad_max_x=30,velocidad_max_y=30;
    private Vector2 direccion;
    public float[] intensidad = new float[2];
    private Vector3 direccion_gravedad;
    Girar_personaje_por_camara gira;
    private float anguloY;
    private string[] desciciones_update = new string[3];    //0=update,1=fixeupdate,2=lateupdate
    
    #region acciones gravedad
    Gravedad cambiar_gravedad = new Gravedad();
    #endregion

    #endregion

    #region funciones monovehaviour
    private void Awake()
    {
        //manos_sonic.tacto_manos;
        //l.iniciar_objeto();
        #region iniciar atributos
        control[1] = new Control();
        control[0] = new Control();     //es para controlar la camara
        gira = new Girar_personaje_por_camara();
        control[2] = new Control();
        //control[3] = new Control();
        #endregion

        #region acciones de controles
        control[0].control_gamepad.Camara.performed += ctx => entrada_camara(ctx);
        control[1].control_gamepad.moverse.performed += ctx => entrada_mover(ctx);
        control[2].control_gamepad.brincar.performed += ctx => brinca();
        //control[3].control_gamepad.gravedad.performed += ctx => cambiar_gravedad.cambiar_gravedad(direccion);
        #endregion

        #region salidas de controles
        control[0].control_gamepad.Camara.canceled += ctx => salida_camara(ctx);
        control[1].control_gamepad.moverse.canceled += ctx => salida_mover(ctx);
        control[2].control_gamepad.brincar.canceled += ctx => cae();
        #endregion
    }

    void Start()
    {
        cambiar_gravedad.iniciar_atributos(Physics.gravity);
        direccion_gravedad = Physics.gravity;
        pies_sonic.tacto_pies = "pisa nada";
        manos_sonic.tacto_manos = "toca nada";
        cabeza_sonic.tacto_cuerpo = "no es atacado";
    }

    // Update is called once per frame
    void Update()
    {
        controlar_.estado_por_control(sonic,pies_sonic.tacto_pies,manos_sonic.tacto_manos,cabeza_sonic.tacto_cuerpo,control);
        rayo(new Vector3(0.0f,0.01f,0.0f));
    }

    private void FixedUpdate()
    {
            
        cambiar_gravedad.atraccion_gravedad(impulso);
        switch(desciciones_update[1])
        {
            case "moverse":
            if((impulso.velocity.x < velocidad_max_x))
            {
        impulso.AddRelativeForce(new Vector3(direccion.x * velocidad.x,0,direccion.y * velocidad.y),ForceMode.Force);
            }
            else
            {
        impulso.AddRelativeForce(new Vector3(direccion.x * desaceleracion.x,0,direccion.y * desaceleracion.y),ForceMode.Force);
            }
            break;
        }
    }

    private void LateUpdate()
    {
        //cambiar_gravedad.girar_camara(Camara_control.camara,direccion);
        //cambiar_gravedad.girar_personaje(transform,direccion);
        pisarnormal.ajustar_angulo(transform,Physics.gravity);
        gira.girar_personaje(transform,direccion);
        checked
        {
        gira.girar(direccion,personaje);    //gira al personaje
        }    
    }

    private void OnEnable()
    {
        control[0].control_gamepad.Camara.Enable();    
        control[1].control_gamepad.moverse.Enable();
        control[2].control_gamepad.brincar.Enable();
        //control[3].control_gamepad.gravedad.Enable();
    }

    private void OnDisable()
    {
        control[0].control_gamepad.Camara.Disable();
        control[1].control_gamepad.moverse.Disable();
        control[2].control_gamepad.brincar.Disable();
        //control[3].control_gamepad.gravedad.Disable();
    }
    
    private void OnCollisionEnter(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "suelo":
                pies_sonic.tacto_pies = "pisando";
                desciciones_update[1] = "moverse";
            break;

            case "plataforma":
                pies_sonic.tacto_pies ="pisando";
                desciciones_update[1] = "moverse";
            break;
            case "roca lia":
                control[2].control_gamepad.brincar.Disable();
                //desciciones_update[1] = "";
                pies_sonic.tacto_pies = "pisando";
            break;
            case "obstaculo":
                desciciones_update[1] = "";
            break;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        switch(other.gameObject.tag)
        {
            case "suelo":
                pies_sonic.tacto_pies = "pisa nada";
            break;
            case "plataforma":
                pies_sonic.tacto_pies ="pisa nada";
            break;
            case "roca lia":
                control[2].control_gamepad.brincar.Enable();
                desciciones_update[1] = "moverse";
                pies_sonic.tacto_pies = "pisa nada";
            break;
            case "obstaculo":
                desciciones_update[1] = "moverse";
            break;
        }
    }

    #endregion de funciones monovehaviour

    #region funciones de entrada y salida de controles
    private void entrada_camara(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        Camara_control.direccion = l.ReadValue<Vector2>();
    }

    private void salida_camara(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        Camara_control.direccion = Vector2.zero;
    }
    
    private void entrada_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = l.ReadValue<Vector2>();
    }

    private void salida_mover(UnityEngine.InputSystem.InputAction.CallbackContext l)
    {
        direccion = Vector2.zero;
    }

public void brinca()
{
    impulso.AddRelativeForce(-direccion_gravedad * intensidad[0],ForceMode.Impulse);
}

public void cae()
{
    impulso.AddRelativeForce(direccion_gravedad * intensidad[1],ForceMode.Impulse);
}

    private void rayo(Vector3 aumento_punto)
    {
        RaycastHit rayo;
        if(Physics.Raycast(transform.position +aumento_punto,personaje.forward,out rayo,2))
        {
            if(rayo.collider.tag == "plataforma")
            {
                transform.Translate(0.0f,0.5f,0.0f);
            }
        }
    }
    #endregion

    #region mis funciones
        private void mantener_impulso_constante()
        {
            switch(impulso.velocity.x,impulso.velocity.y)
            {
                case(<velocidad_max_x,<velocidad_max_y):

                break;
            }
        }
    #endregion

}
