using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "kolona")
        {
            SceneManager.LoadScene(3);
        }

        if (other.gameObject.name == "Monstruo")
        {
            SceneManager.LoadScene(2);
        }

        if (other.gameObject.name == "Monstruo")
        {
            Destroy(other.gameObject);
        }
    }
}
