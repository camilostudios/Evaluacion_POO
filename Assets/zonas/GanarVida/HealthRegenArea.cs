using UnityEngine;

public class HealthRegenArea : MonoBehaviour
{
    public float regenPercent = 20f; // Porcentaje de vida que se carga cada 5 segundos
    public PlayerHealth playerHealth;

    private void Start()
    {
        if (playerHealth == null)
        {
            Debug.LogError("Por favor, asigna el componente PlayerHealth en el inspector.");
        }
        InvokeRepeating("RegenHealth", 0f, 5f);
    }

    private void RegenHealth()
    {
        if (playerHealth != null)
        {
            float amount = playerHealth.maxHealth * (regenPercent / 100f);
            playerHealth.RestoreHealth(amount);
        }
    }
}