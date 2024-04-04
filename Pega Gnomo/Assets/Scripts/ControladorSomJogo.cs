using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ControladorSomJogo : MonoBehaviour
{
    public AudioMixer Mixer_audio;

    //Parametros de volume
    private float audio_desligado = -80.0f;
    private float audio_ligado = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Mixer de som geral
    public void LigaSom()
    {
        Mixer_audio.SetFloat("VolMaster", audio_ligado);
    }

    public void DesligaSom()
    {
        Mixer_audio.SetFloat("VolMaster", audio_desligado);
    }

    //Mixer de sons de fundo
    public void LigaSomBG()
    {
        Mixer_audio.SetFloat("VolBG", audio_ligado);
    }

    public void DesligaSomBG()
    {
        Mixer_audio.SetFloat("VolBG", audio_desligado);
    }

    //Mixer de sons de efeito
    public void LigaSomEfeito()
    {
        Mixer_audio.SetFloat("VolEfeito", audio_ligado);
    }

    public void DesligaSomEfeito()
    {
        Mixer_audio.SetFloat("VolEfeito", audio_desligado);
    }
}
