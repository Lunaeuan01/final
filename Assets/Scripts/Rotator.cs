using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Velocidad de rotaci�n en grados por segundo
    public float rotationSpeed = 120f;

    void Update()
    {
        // Rotar el objeto alrededor del eje Y (puedes cambiar el eje seg�n tus necesidades)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
