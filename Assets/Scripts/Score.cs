using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayScore : MonoBehaviour
{
    public TextMeshProUGUI playScore;          // crea una variable pública tipo text para el score del jugador
    public static float contador;          // crea una variable estatica tipo float para el contador
    // Update is called once per frame
    void Update()
    {

        contador += Time.deltaTime/2;           // el contador se va sumando mientras pasa el tiempo y el 1.5f sirve para hacer más rapido la cuenta
        playScore.text = Mathf.Round(contador) + " "; // Convierte los valores calculados a texto y los redonde usando la funcion de Mathf.round

    }


}