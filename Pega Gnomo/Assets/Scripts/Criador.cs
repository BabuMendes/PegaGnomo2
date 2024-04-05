using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criador : MonoBehaviour
{
    public GameObject Galho;
    
    public GameObject MacaComum;

    public float meutempo = 0;

    private GerenciadorDoJogo GJ;

    public List<GameObject> Frutas;

    public int LimiteFruta = 1;

    public float pinicial;

    public float pfinal;

    // Start is called before the first frame update
    void Start()
    {

        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDoJogo>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GJ.EstadoDoJogo() == true)
        {
            Temporizador();
        }
 
    }

    void Temporizador()
    {
        meutempo += Time.deltaTime;
        if (meutempo > 1)
        {
            meutempo = 0;
            float chance = Random.Range(0, 30);
            if (chance <= 20)
            {
                CriaGalhos();
            }
            else
            {
                CriaFruta();
            }
        }
    }

    void CriaGalhos()
    {
        float posX = posfruta();
        Vector3 posInicial = new Vector3(posX, 1, 0);
        GameObject MeuGalho = Instantiate(Galho, posInicial, Quaternion.identity);
        Destroy(MeuGalho, 2f);
    }

    void CriaMacas()
    {
        float posX = posfruta();
        Vector3 posInicial = new Vector3(posX, 1, 0);
        GameObject MinhaMaca = Instantiate(MacaComum, posInicial, Quaternion.identity);
        Destroy(MinhaMaca, 2f);
    }

    void CriaFruta()
    {
        LimiteFruta = PlayerPrefs.GetInt("nivelFruta");
        int FrutasColidas = Random.Range(0, LimiteFruta);
        float posX = posfruta();

        Vector3 posInicial = new Vector3(posX, 1, 0);
        GameObject MinhaMaca = Instantiate(Frutas[FrutasColidas], posInicial, Quaternion.identity);
        Destroy(MinhaMaca, 2f);
    }

    float posfruta()
    {
        float posX = 0;
        int arvore = Random.Range(0, 4);
        if (arvore == 0)
        {
            posX = Random.Range(-5.9f, -3.9f);
        }

        if (arvore == 1)
        {
            posX = Random.Range(-1.9f, 1.9f);
        }

        if (arvore == 2)
        {
            posX = Random.Range(3.9f, 6.9f);
        }
        return posX;
    }
}
