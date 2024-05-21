using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "kolona")
        {
            SceneManager.LoadScene(2);
        }

        if (other.gameObject.name == "Monstruo" || other.gameObject.name == "Monstruo (1)" || other.gameObject.name == "Monstruo (2)" /*|| other.gameObject.name == "Monstruo (3)" || other.gameObject.name == "Monstruo (4)"*/)
        {
            SceneManager.LoadScene(3);
        }
    }
}
