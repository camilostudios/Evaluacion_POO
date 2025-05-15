using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    [SerializeField] private float velocidad = 5f; // Velocidad de movimiento
    [SerializeField] private Vector3 limitesMinimos = new Vector3(-10f, -5f, -10f); // Límites mínimos
    [SerializeField] private Vector3 limitesMaximos = new Vector3(10f, 5f, 10f); // Límites máximos

    private void Update()
    {
        // 1. Obtener inputs del teclado (WASD + Q/E para altura)
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // A/D
        float movimientoVertical = Input.GetAxis("Vertical"); // W/S
        float movimientoAltura = 0f;

        // Corregido: Usar Input.GetKey en lugar de !Input.GetKey
        if (Input.GetKey(KeyCode.Q)) movimientoAltura = -1f; // Bajar (Q)
        if (Input.GetKey(KeyCode.E)) movimientoAltura = 1f; // Subir (E)

        // 2. Calcular la dirección del movimiento
        Vector3 direccion = new Vector3(movimientoHorizontal, movimientoAltura, movimientoVertical).normalized;

        // 3. Mover el objeto (usando Transform.Translate o Rigidbody)
        if (direccion != Vector3.zero)
        {
            // Opción 1: Movimiento simple (sin física)
            transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);

            // Opción 2: Movimiento con física (recomendado si usas Rigidbody)
            // GetComponent<Rigidbody>().MovePosition(transform.position + direccion * velocidad * Time.deltaTime);
        }

        // 4. Limitar la posición dentro del espacio definido
        Vector3 posicionActual = transform.position;
        posicionActual.x = Mathf.Clamp(posicionActual.x, limitesMinimos.x, limitesMaximos.x);
        posicionActual.y = Mathf.Clamp(posicionActual.y, limitesMinimos.y, limitesMaximos.y);
        posicionActual.z = Mathf.Clamp(posicionActual.z, limitesMinimos.z, limitesMaximos.z);
        transform.position = posicionActual;
    }
}