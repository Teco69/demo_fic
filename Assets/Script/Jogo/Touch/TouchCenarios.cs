using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TouchCenarios : MonoBehaviour
{
    public string cena;
        
   
    void Start(){

        



    }
    void OnMouseOver(){

        
        //new Vector3(0.206995f, 0.1811455f, 0.1811455f);



       if(Input.GetMouseButtonDown(0)){

            SceneManager.LoadScene(cena);

       }


    }

    void OnMouseExit(){

      //normal Vector3(0.1910931f, 0.1672295f, 0.1672295f);



    }
    void Update(){

    }

}
