using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteragirPersonagem : MonoBehaviour
{

    public ControleDialogos controle;
    public Dialogos dialogo;

    public void OnMouseOver(){

        if(Input.GetMouseButtonDown(0)){
            controle.iniciarDialogo(dialogo);
            
        
        }



    }
}
