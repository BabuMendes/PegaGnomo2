using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    //Variavel Texto de Valor do Cora��o
    public Text valorCoracao;
    public Text valorFruta;
    //Informa��o do Banco

    private Banco MeuBanco;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        MeuBanco = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
    }

    // Update is called once per frame
    void Update()
    {
        //Informa��o do n�vel do cora��o
        int vidascompradas = PlayerPrefs.GetInt("nivelVida") + 1;
        int custo = (vidascompradas * 10);
        valorCoracao.text = "VIDA LV: " + vidascompradas.ToString() + " $: " + custo.ToString();

        int frutascompradas = PlayerPrefs.GetInt("nivelFruta") + 1;
        if (frutascompradas < 6)
        {
            int custoFruta = (frutascompradas * 100);
            valorFruta.text = "FRUTA LV: " + frutascompradas.ToString() + " $: " + custoFruta.ToString();
        }
        else
        {
            valorFruta.text = "LIMITE ATINGIDO";
        }
    }

    //Realizar Comprar

    public void ComprarCoracao()
    {
        int vidascompradas = PlayerPrefs.GetInt("nivelVida") + 1;
        int custo = (vidascompradas * 10);
        if (MeuBanco.Pagar(custo) == true)
        {
            //Conseguiu Comprar
            PlayerPrefs.SetInt("nivelVida", vidascompradas);
        }
        else
        {
            //N�o conseguiu comprar
        }
    }

    public void ComprarFruta()
    {
        int frutascompradas = PlayerPrefs.GetInt("nivelFruta") + 1;
        if (frutascompradas < 6)
        {
            int custoFruta = (frutascompradas * 100);
            if (MeuBanco.Pagar(custoFruta) == true)
            {
                //Conseguiu Comprar
                PlayerPrefs.SetInt("nivelFruta", frutascompradas);
            }
            else
            {
                //N�o conseguiu comprar
            }
        }
    }
}
