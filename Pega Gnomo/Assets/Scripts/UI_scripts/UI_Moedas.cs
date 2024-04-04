using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Moedas : MonoBehaviour
{
    private Gnomo InfoJogador;
    private Text MeuTexto;

    // Start is called before the first frame update
    void Start()
    {
        InfoJogador = GameObject.FindGameObjectWithTag("Player").GetComponent<Gnomo>();
        MeuTexto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MeuTexto.text = InfoJogador.macas.ToString();
    }
}
