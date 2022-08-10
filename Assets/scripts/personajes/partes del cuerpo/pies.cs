using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pies : MonoBehaviour
{
    public string tacto_pies;
    private void OnTriggerEnter(Collider other)
    {
     switch(other.gameObject.tag)
     {
         case "suelo":
            Debug.Log("es pisando suelo");
            tacto_pies = "pisando";
         break;
         case "plataforma":

         break;

         case "roca lia":

         break;

         case "pared":

         break;

         case "npc":

         break;
         case "objeto":

         break;
         case "ring":

         break;
     }   
    }
    
    private void OnTriggerExit(Collider other)
    {
     switch(other.gameObject.tag)
     {
         case "suelo":
            Debug.Log("se dejo de tocar suelo");
            tacto_pies = "pisa nada";
         break;
         case "plataforma":

         break;

         case "roca lia":

         break;

         case "pared":

         break;

         case "npc":

         break;
         case "objeto":

         break;
         case "ring":

         break;
     }  
    }

}
