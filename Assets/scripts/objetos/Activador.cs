using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activador : MonoBehaviour
{
    [SerializeField] GameObject segundo;

    private void OnTriggerEnter(Collider other)
    {
        switch(other.gameObject.name)
        {
            case "Sonic":
            Gravedad.activar = true;
            segundo.SetActive(true);
            gameObject.SetActive(false);
            break;
            case "suela":
            Gravedad.activar = true;
            segundo.SetActive(true);
            gameObject.SetActive(false);
            break;
        }
    }
}
