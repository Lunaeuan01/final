using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // Referencia al transform del jugador

    void Update()
    {
        // Verificar si el jugador está asignado
        if (player != null)
        {
            // Actualizar la posición del Skydome para que coincida con la del jugador
            transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
        }
        else
        {
            Debug.LogWarning("El jugador no está asignado en el script FollowPlayer.");
        }
    }
}
