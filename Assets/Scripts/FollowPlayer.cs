using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador

    void Update()
    {
        // Verificar si el jugador est� asignado
        if (player != null)
        {
            // Actualizar la posici�n del Skydome para que coincida con la del jugador
            transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
        }
        else
        {
            Debug.LogWarning("El jugador no est� asignado en el script FollowPlayer.");
        }
    }
}
