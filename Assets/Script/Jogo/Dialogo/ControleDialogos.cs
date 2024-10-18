using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControleDialogos : MonoBehaviour
{
    // variaveis da Caixa de Dialogo
    public GameObject caixaDialogo;
    public Image expressaoPersonagem;
    public TextMeshProUGUI nomePersonagem;
    public TextMeshProUGUI falaPersonagem;
    


    // variaveis para o controle do sistema de dialogo

    private Dialogos dialogoAtual;

    int indice;

    Queue<string> filaDialogo;

    public void iniciarDialogo(Dialogos dialogo){
        caixaDialogo.SetActive(true);
        filaDialogo = new Queue<string>();
        dialogoAtual = dialogo;
        indice = 0;
        proximoDialogo();
    }
    public void proximoDialogo(){

        if (filaDialogo.Count == 0){
            if (indice < dialogoAtual.falas.Length){
                //carregando a imagem do personagem
                expressaoPersonagem.sprite = dialogoAtual.falas[indice].personagem.expressoesPersonagem[dialogoAtual.falas[indice].idExpressao];
               // expressaoPersonagem.SetNativeSize(); //ajusta o tamnho padrão
                //carregando o nome do personagem
                nomePersonagem.text = dialogoAtual.falas[indice].personagem.NomePersonagem;
                //Laço para carregar os textos das falas
                foreach(string textoFalas in dialogoAtual.falas[indice].textoFalas){
                    filaDialogo.Enqueue(textoFalas);
                }
                indice++;
            }else{
                caixaDialogo.SetActive(false);
                return;
                
            }

        }
        falaPersonagem.text = filaDialogo.Dequeue();
    }





}
