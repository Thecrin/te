using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manos : MonoBehaviour
{
    public string tacto_manos;
    private void OnTriggerEnter(Collider other)
    {
     switch(other.gameObject.tag)
     {
         case "suelo":

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
