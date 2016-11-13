using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; // Usamos la libreria del motor de Unity llamada SceneManagement

public class ColisionMeta : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    // Función para la llegada a meta
    void OnTriggerEnter(Collider other) //Cuando se detecte una activación captura el collider propio y el objeto que lo activa
    {
        if (other.tag == "Player") // Si el tag del objeto activador tiene un tag llamado "Player"
        {
            Destroy(other.gameObject); // Destruye el objeto de juego del objeto activador
            SceneManager.LoadScene("Final Ganador"); // Y carga la escena llamada "Final Ganador" 

        }
    }
}
