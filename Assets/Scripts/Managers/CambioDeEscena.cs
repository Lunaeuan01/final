using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Método para cargar una nueva escena
    public void CambiarEscena(string nombreEscena)
    {
        // Cargar la escena especificada por su nombre
        SceneManager.LoadScene(nombreEscena);
    }

    // Método para recargar la escena actual
    public void RecargarEscenaActual()
    {
        // Obtener el nombre de la escena actual
        string escenaActual = SceneManager.GetActiveScene().name;
        // Recargar la escena actual por su nombre
        SceneManager.LoadScene(escenaActual);
    }

    // Método para cargar una escena de manera asincrónica
    public void CambiarEscenaAsincrono(string nombreEscena)
    {
        // Iniciar la carga asincrónica de la escena especificada
        StartCoroutine(CargarEscenaAsync(nombreEscena));
    }

    // Coroutine para cargar una escena de manera asincrónica
    private IEnumerator CargarEscenaAsync(string nombreEscena)
    {
        // Comenzar a cargar la escena de manera asincrónica
        AsyncOperation operacion = SceneManager.LoadSceneAsync(nombreEscena);

        // Opcionalmente, puedes mostrar un progreso de carga o realizar otras acciones mientras esperas
        while (!operacion.isDone)
        {
            // Puedes acceder a operacion.progress para obtener el progreso de carga (entre 0 y 1)
            // Puedes mostrar una barra de progreso, animaciones, etc.
            yield return null;
        }
    }
}
