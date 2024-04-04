using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private float speed = 0f;

    public SpriteRenderer ImagemPersonagem;

    private GerenciadorDoJogo GJ;
    private float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJogo>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
        Apontar();
    }

    void Movimentar()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = 0;
        velocidade = horizontal;
        Debug.Log(horizontal);
        Debug.Log(vertical);
        //Vector2 shipVel = new Vector2(horizontal, vertical);

        //shipVel.Normalize();
        rb2d.velocity = new Vector2(5* horizontal, 0);
    }

    void Apontar()
    {
        if (velocidade > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (velocidade < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
