using UnityEngine;
public class RotacionarCamera : MonoBehaviour
{
    public  Transform corpoDoJogador;
    public float sensibilidade;
    private float rotacaoX;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    void Update()
    {
        RotacionarJogador();    
    }

    private void RotacionarJogador()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensibilidade * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensibilidade * Time.deltaTime;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        corpoDoJogador.Rotate(Vector3.up * mouseX);
    }
}
