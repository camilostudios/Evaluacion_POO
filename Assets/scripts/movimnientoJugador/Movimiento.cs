using UnityEngine;

public class Movimiento : MonoBehaviour

{
    [Header("Configuración de Movimiento")]
    public float velocidad = 5f; // Velocidad de movimiento
    public Vector3 limitesMinimos = new Vector3(-10f, -5f, -10f); // Límites mínimos (X, Y, Z)
    public Vector3 limitesMaximos = new Vector3(10f, 5f, 10f);    // Límites máximos (X, Y, Z)

    void Update()
    {
        // 1. Obtener inputs del teclado (WASD + Q/E para altura)
        float movimientoHorizontal = Input.GetAxis("Horizontal"); // A/D o ←/→
        float movimientoVertical = Input.GetAxis("Vertical");     // W/S o ↑/↓
        float movimientoAltura = 0f;

        if (Input.GetKey(KeyCode.Q)) movimientoAltura = -1f; // Bajar (Q)
        if (Input.GetKey(KeyCode.E)) movimientoAltura = 1f;  // Subir (E)

        // 2. Calcular la dirección del movimiento
        Vector3 direccion = new Vector3(movimientoHorizontal, movimientoAltura, movimientoVertical);

        // 3. Mover el objeto
        transform.Translate(direccion * velocidad * Time.deltaTime);

        // 4. Limitar la posición dentro del espacio definido
        Vector3 posicionActual = transform.position;
        posicionActual.x = Mathf.Clamp(posicionActual.x, limitesMinimos.x, limitesMaximos.x);
        posicionActual.y = Mathf.Clamp(posicionActual.y, limitesMinimos.y, limitesMaximos.y);
        posicionActual.z = Mathf.Clamp(posicionActual.z, limitesMinimos.z, limitesMaximos.z);
        transform.position = posicionActual;
    }
}