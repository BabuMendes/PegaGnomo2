using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gnomo : MonoBehaviour
{
    private int vida = 3;
    public int macas = 0;
    private GerenciadorDoJogo GJ;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("nivelVida", 0);
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJogo>();
    }

    public void Inicializar()
    {
        int vidas_compradas = PlayerPrefs.GetInt("nivelVida");
        vida = vida + vidas_compradas;
    }

    public int InformaVida()
    {
        return vida;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Inimigo")
        {
            ///Chamar Som Galho
            GameObject.FindGameObjectWithTag("tag_som_galho").GetComponent<AudioSource>().Play();
            Destroy(colisao.gameObject);
            vida--;
            if (vida <= 0)
            {
                GJ.ReceberMoedaMorreu(macas);
                GJ.Morreu();
            }
        }

        if (colisao.gameObject.tag == "Coletavel")
        {
            ///Chamada do Som Maçã
            ///
            GameObject.FindGameObjectWithTag("tag_som_maca").GetComponent<AudioSource>().Play();
            Destroy(colisao.gameObject);
            macas++;
        }
    }
}
