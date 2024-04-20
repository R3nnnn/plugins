using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    [Header("----------- Audio Source ------------")]
    [SerializeField] private AudioSource musicSource;

    [Header("----------- Audio Clip ------------")]
    public List<AudioClip> music;

    private void Start()
    {
        musicSource.clip = music[0];
        musicSource.Play();
    }

    private void Update()
    {
        //Poner que cuando el guardián detecte al jugador, la música cambie a musicSource.clip = music[1]
    }
}
