using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class simondice : MonoBehaviour
{
    public List<GameObject> teclas;
    public List<GameObject> rand;
    public List<int> Toques;
    public Material tecla1;
    public Material tecla2;

    private int currentStep = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(corutinaTiempo());
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar las teclas presionadas por el usuario
        if (Input.anyKeyDown)
        {
            // Comprobar si la tecla presionada coincide con la siguiente en la secuencia
            if (Input.GetKeyDown(KeyCode.Alpha1) && rand[currentStep] == teclas[0])
            {
                Debug.Log("Tecla 1 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2) && rand[currentStep] == teclas[1])
            {
                Debug.Log("Tecla 2 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) && rand[currentStep] == teclas[2])
            {
                Debug.Log("Tecla 3 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4) && rand[currentStep] == teclas[3])
            {
                Debug.Log("Tecla 4 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5) && rand[currentStep] == teclas[4])
            {
                Debug.Log("Tecla 5 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6) && rand[currentStep] == teclas[5])
            {
                Debug.Log("Tecla 6 presionada");
                currentStep++;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha7) && rand[currentStep] == teclas[6])
            {
                Debug.Log("Tecla 7 presionada");
                currentStep++;
            }
            else
            {
                SceneManager.LoadScene(5);
                
            }

            // Comprobar si se completó la secuencia
            if (currentStep == rand.Count)
            {
                SceneManager.LoadScene(4);
                
                //currentStep = 0;
            }
        }
    }

    IEnumerator corutinaTiempo()
    {
        rand.Clear();

        for (int i = 0; i < 5; i++)
        {
            int RandomNumber = Random.Range(0, 7);
            teclas[RandomNumber].GetComponent<MeshRenderer>().material.color = Color.green;
            teclas[RandomNumber].GetComponent<MeshRenderer>().material = tecla1;
            teclas[RandomNumber].GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(1);
            teclas[RandomNumber].GetComponent<MeshRenderer>().material.color = Color.white;
            teclas[RandomNumber].GetComponent<MeshRenderer>().material = tecla2;
            yield return new WaitForSeconds(1);
            rand.Add(teclas[RandomNumber]);
        }
    }
}
