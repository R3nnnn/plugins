using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Slider brillo;
    public float valorS; //valor del slider
    public Image panelBrillo; //cambiaremos el alfa dee ste componente

    void Start()
    {
        brillo.value = PlayerPrefs.GetFloat("brillo", 0.5f); //si no tiene ningun valor, le asignará .5 de manera predefinida
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, brillo.value); //Alfa igual al valorS
        
    }


    void Update()
    {
        
    }

    public void ModificarSlider(float valor)
    {
        valorS = valor;
        PlayerPrefs.SetFloat("brillo", valorS); //Guardamos el valor nuevo
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, brillo.value); //cambia el alfa
    }
}
