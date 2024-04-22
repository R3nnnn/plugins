using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class simondice : MonoBehaviour
{
    public List<GameObject> teclas;
    public Material tecla1;
    public Material tecla2;

    private List<GameObject> secuencia = new List<GameObject>();
    private int currentStep = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CorutinaTiempo());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown)
        {
            SimonD();
        }

        if (currentStep == secuencia.Count)
        {
            SceneManager.LoadScene(4);
        }
    }

    void SimonD() //Verifica si el jugador ha completado la secuencia
    {
        if (currentStep < secuencia.Count)
        {

            for (int i = 0; i < teclas.Count; i++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + i) && teclas[i] == secuencia[currentStep])
                {
                    Debug.Log("Tecla " + (i + 1) + " presionada");
                    currentStep++;
                    return; // Sale del bucle cuando encuentra la tecla correcta
                }
                else
                {
                    ContadorVidas.scoreCount -= 1;
                }
            }

            // Si no se encontró ninguna tecla correcta se va a gameover

            SceneManager.LoadScene(5);
        }
    }

    IEnumerator CorutinaTiempo()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomIndex = Random.Range(0, teclas.Count);
            GameObject tecla = teclas[randomIndex];
            secuencia.Add(tecla);

            tecla.GetComponent<MeshRenderer>().material = tecla1;
            tecla.GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(1);

            tecla.GetComponent<MeshRenderer>().material = tecla2;
            yield return new WaitForSeconds(1);
        }
    }
}
