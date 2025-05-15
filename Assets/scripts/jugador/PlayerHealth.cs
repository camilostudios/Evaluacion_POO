using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider vidaSlider; // Referencia al Slider de vida

    public float maxVida = 100f;
    private float currentVida;

    private void Start()
    {
        currentVida = maxVida;
        UpdateVidaSlider();
    }

    private void UpdateVidaSlider()
    {
        vidaSlider.value = currentVida / maxVida; // Normalización del valor del Slider
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PerderVida")) // Área que reduce la vida
        {
            currentVida -= maxVida * 0.1f; // Reduce el 10% de la vida máxima
            currentVida = Mathf.Clamp(currentVida, 0f, maxVida); // Evita valores negativos
            
            UpdateVidaSlider();
            Debug.Log("El jugador ha perdido 10% de vida.");
        }
    }
}
