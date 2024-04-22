using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVidas : MonoBehaviour
{
    public TextMeshProUGUI scoreText;                  // Crea una variable tipo text para las vidas del jugador
    public static int scoreCount = 3;       // Crea una variable statica tipo int que le da valor 3 para indicar las vidas del jugador al iniciar el juego



    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreCount + " Lifes";        //Convierte el valor de scoreCount a texto y le añade la palabra
                                                       //"lifes" para indicar las vidas del jugador


    }
}
