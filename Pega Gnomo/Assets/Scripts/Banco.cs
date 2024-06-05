using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    private int valorBanco;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GuardarNoBanco(int novoValor)
    {
        //Recebo o que eu já tenho no banco
        valorBanco = PlayerPrefs.GetInt("minhasMoedas");
        //Somo com o novo valor
        valorBanco = valorBanco + novoValor;
        //Guardo o valor total
        PlayerPrefs.SetInt("minhasMoedas", valorBanco);
    }

    //Informa a quantidade de dinheiroque eu possuo

    public int InformarValorNoBanco()
    {
        valorBanco = PlayerPrefs.GetInt("minhasMoedas");
        return valorBanco;
    }

    //Retirada

    public void RetirardoBanco(int novoValor)
    {
        //Recebo o que eu já tenho no banco
        valorBanco = PlayerPrefs.GetInt("minhasMoedas");
        //Subtrair o novo valor
        valorBanco = valorBanco - novoValor;
        //Guardo o valor total
        PlayerPrefs.SetInt("minhasMoedas", valorBanco);
    }

    //Voce pagar

    public bool Pagar(int custo)
    {
        int dinheiroBanco = InformarValorNoBanco();
        if (dinheiroBanco >= custo)
        {
            //Puder pagar e paguei
            //GameObject.FindGameObjectWithTag("tag_som_moeda").GetComponent<AudioSource>().Play();
            AudioManager.instance.PlaySFX("Compra");
            RetirardoBanco(custo);
            return true;
        }
        else
        {
            //Não pude pagar
            return false;
        }
    }
}
