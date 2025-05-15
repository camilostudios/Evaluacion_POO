using UnityEngine;

public class EspadaSeguirJugador : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public Vector3 offset = new Vector3(0.5f, 0, 0); // Posición relativa de la espada
    public float followSpeed = 5f; // Velocidad de seguimiento

    private void Start()
    {
        if (player != null)
        {
            // Establecer la posición inicial en el jugador
            transform.position = player.position + offset;
            
            // Convertir la espada en un hijo del jugador para que siempre lo siga
            transform.SetParent(player);
        }
    }

    private void LateUpdate()
    {
        if (player == null) return;

        try
        {
            // Mantener la espada en la posición del jugador + offset
            transform.position = player.position + offset;
            transform.rotation = player.rotation;
        }
        catch (System.Exception ex)
        {
            Debug.LogWarning($"Error al seguir al jugador: {ex.Message}");
        }
    }
}
