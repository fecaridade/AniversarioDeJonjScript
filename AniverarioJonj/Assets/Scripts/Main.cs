
using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
public class Main : MonoBehaviour
{
    
    //Poderia ser uma Lista, mas o Projeto é pequeno.
    [SerializeField] private AudioClip musicaAniversario;
    [SerializeField] private List<AudioClip> musicas;
    public string hourMinute;
    [SerializeField]private Text tempo_Restante;
    private bool podesortear;

    void Start()
    {

        tempo_Restante = GameObject.Find("TempoRestante").GetComponent<Text>();
    }

    
    void Update()
    {
        
        
    }


    private void FixedUpdate()
    {
        hourMinute = DateTime.Now.ToString("HH:mm");
        float Hora = Convert.ToInt32(hourMinute.Substring(0, 2));
        float Minutos = Convert.ToInt32(hourMinute.Substring(3, 2));
        float horasRestantes = 14 - Hora;
        float minutosRestantes = 35 - Minutos;
        tempo_Restante.text = "Tempo Restante Para supresa" + "\n"+horasRestantes + ":" + minutosRestantes + "\n" + "\n" +"Escute uma musica enquanto a hora nao chega...";
        print(Hora+" "+Minutos);
        if (Hora == 14 && Minutos == 40)
        {
            
            AudioManager.Instance.PlayMusic(musicaAniversario,1f);
        }
        
        
    }

    void sorteiaMusica()
    {
        int rnd = Random.Range(0, musicas.Count);
        print(rnd + "Musica Escolhida");
        foreach (AudioClip audioClip in musicas)
        {
            if (musicas.IndexOf(audioClip) == rnd)
            {
                AudioManager.Instance.PlayMusic(audioClip,1f);    
            }
            
        }
    }
}



