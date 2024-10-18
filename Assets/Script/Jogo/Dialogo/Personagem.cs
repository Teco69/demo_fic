using UnityEngine;
[CreateAssetMenu (fileName ="Novo Personagem", menuName="Dialogo/Personagem")]

public class Personagem : ScriptableObject
{
   public string NomePersonagem; //ira criar um campo para o nome do personagem

   public Sprite[] expressoesPersonagem; //armazena uma lista de sprite
}
