using UnityEngine;
[CreateAssetMenu(fileName="DialogoPersonagem", menuName="Dialogo/Dialogos")]

public class Dialogos : ScriptableObject
{
    public FalasDaConversa[] falas;    
}
[System.Serializable]

public class FalasDaConversa{
    public Personagem personagem;

    public int idExpressao;
    [TextArea]

    public string[] textoFalas;
}