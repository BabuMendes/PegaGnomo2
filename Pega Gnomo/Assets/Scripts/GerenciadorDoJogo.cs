using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDoJogo : MonoBehaviour
{
    public bool jogoON = false;
    //Chamar Menu de Game Over
    public GameObject MenuGameOVER;
    private Banco MeuBanco;

    // Start is called before the first frame update
    void Start()
    {
        MeuBanco = GetComponent<Banco>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJogo()
    {
        jogoON = true;
        Time.timeScale = 1;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Gnomo>().Inicializar();
    }

    public bool EstadoDoJogo()
    {
        return jogoON;
    }

    public void Morreu()
    {
        jogoON = false;
        Time.timeScale = 0;
        MenuGameOVER.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }

    public void ReceberMoedaMorreu(int n_macas)
    {
        MeuBanco.GuardarNoBanco(n_macas);
    }
}
