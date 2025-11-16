using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    public CharacterController controlador;
    public float velocidade;
    void Start()
    {
        
    }
    void Update()
    {
        MoverJogador();
    }

    private void MoverJogador()
    {
        float movimentoX = Input.GetAxis("Horizontal");
        float movimentoZ = Input.GetAxis("Vertical");

        Vector3 movimento = transform.right * movimentoX + transform.forward * movimentoZ;

        controlador.Move(movimento * velocidade * Time.deltaTime);    
    }    
}
