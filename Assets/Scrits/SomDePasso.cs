using UnityEngine;

public class SomDePasso : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] passos;

    public float passoWalk = 0.52f;
    public float passoRun = 0.38f;

    private float tempoPasso;
    private Vector3 ultimaPosicao;

    void Start()
    {
        ultimaPosicao = transform.position;
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, ultimaPosicao);
        float velocidade = distancia / Time.deltaTime;

        ultimaPosicao = transform.position;

        if (velocidade > 0.1f)
        {
            tempoPasso -= Time.deltaTime;

            float intervalo = velocidade > 5f ? passoRun : passoWalk;

            if (tempoPasso <= 0f)
            {
                TocarPasso();
                tempoPasso = intervalo;
            }
        }
        else
        {
            tempoPasso = 0f;
        }
    }

    void TocarPasso()
    {
        if (passos.Length == 0) return;

        AudioClip clip = passos[Random.Range(0, passos.Length)];
        audioSource.PlayOneShot(clip);
    }
}
