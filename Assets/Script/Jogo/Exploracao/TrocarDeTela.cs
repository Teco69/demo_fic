using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrocarDeTela : MonoBehaviour
{
    public string cena;
    public GameObject textoE;

   void OnCollisionStay2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            textoE.SetActive(true);
        }

    if(Input.GetKeyDown(KeyCode.E)){

        SceneManager.LoadScene(cena);



    }



   }
}
