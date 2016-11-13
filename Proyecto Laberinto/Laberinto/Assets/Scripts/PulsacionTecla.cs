using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Usamos la libreria de SceneManagement

public class PulsacionTecla : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.anyKey) // Si cualquier tecla es pulsada
        {
            SceneManager.LoadScene("Laberinto 1"); // Cargamos la escena llamada "Laberinto 1"
        }
	}
}
