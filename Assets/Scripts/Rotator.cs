using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 120f;

    void Update()
    {
        // Rotar el objeto alrededor del eje Y (puedes cambiar el eje según tus necesidades)
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
