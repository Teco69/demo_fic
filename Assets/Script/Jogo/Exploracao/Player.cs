using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speedAtual = 12.0f;
    public SpriteRenderer spriteRenderer;
    public Sprite  Cima, Baixo, Esquerda, Direita;        // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speedAtual * entradaHorizontal);

         float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speedAtual * entradaVertical);

        if(Input.GetKeyDown(KeyCode.D)){

            spriteRenderer.sprite = Direita;


        }

        if(Input.GetKeyDown(KeyCode.A)){

            spriteRenderer.sprite = Esquerda;


        }

        if(Input.GetKeyDown(KeyCode.S)){

            spriteRenderer.sprite = Baixo;


        }

        if(Input.GetKeyDown(KeyCode.W)){

            spriteRenderer.sprite = Cima;


        }

    
    
    
    }



   
}
