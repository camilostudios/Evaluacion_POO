using UnityEngine;

public class RPGCameraController : MonoBehaviour
{
    [Header("Configuración de la Cámara")]
    [SerializeField] private Transform player; // Arrastra el transform del Player aquí desde el Inspector.
    [SerializeField] private float height = 10f; // Altura fija de la cámara sobre el jugador.
    [SerializeField] private float smoothSpeed = 5f; // Suavizado del movimiento.

    private Vector3 offset; // Distancia inicial entre cámara y jugador.

    private void Start()
    {
        if (player == null)
        {
            Debug.LogError("¡No se ha asignado el transform del Player en el Inspector!");
            return;
        }

        // Calcula el offset inicial (cámara apuntando al jugador desde arriba).
        offset = transform.position - player.position;
        offset = new Vector3(transform.position.x - player.position.x, height, transform.position.z - player.position.z);
 // Fija la altura.
    }

    private void LateUpdate()
    {
        if (player == null) return;

        // Posición objetivo: la posición del jugador + offset (con altura fija).
        Vector3 targetPosition = player.position + offset;

        // Suaviza el movimiento (opcional, elimínalo si quieres seguimiento instantáneo).
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, smoothSpeed * Time.deltaTime);


        // La cámara siempre mira al jugador.
        transform.LookAt(player.position);
        
        if (Vector3.Distance(transform.position, targetPosition) > 0.1f)
{
    transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
}


        
    }
}