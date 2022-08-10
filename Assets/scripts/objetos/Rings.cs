using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rings : MonoBehaviour
{
    public static int cant;
    [SerializeField] Text cantidad;
    private void OnTriggerEnter(Collider other) {
        cant++;
        try     //acciones del ring
        {
            cantidad.text = cant +"";
        }
        catch(UnityException l)
        {

        }

        Destroy(gameObject);    //se destruye el ring
    }

}
