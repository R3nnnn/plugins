using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public Slider volumeSlider;
    public float valorSlider;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("audioVolume", 3f); //Crear un valor para guardar la posición del slider 0.5 es valor predefinido
        AudioListener.volume = volumeSlider.value; //Sacamos el volumen. Va a tener el volumen del valorSlider
    }

    public void ModificarSlider(float value)
    {
        valorSlider = value; //este valor se saca del slider
        PlayerPrefs.SetFloat("audioVolume", valorSlider); //Le ponemos un valor al volumen al mover el slider
        AudioListener.volume = volumeSlider.value;
    }
}
