using system;
using Unity.VisualScriptimg;
using UnityEngine;

   plublic class bau : MonoBehaviour
   {
       public GameObject texto;


       private void OncollisionEnter2D(collision2D other)
       {
           if (other.gameObject.Comparetag(*player*))
       }

       using System;
       using UnityEngine;

       public class Chave : MonoBehaviour
       {
           public GameObject textoDeVitoria;
           private void OnCollisionEnter2D(Collision2D other)
           {
               if (other.gameObject.CompareTag("Player"))
               {
                   textoDeVitoria.SetActive(true);
                   gameObject.SetActive(false);
               }
           }
       }