using UnityEngine;

public class DamageArea : MonoBehaviour
{
    public float damageInterval = 5f; // Intervalo de daño en segundos
    public float damagePercent = 10f; // Porcentaje de daño
    public Color glowColor = Color.blue; // Color del resplandor
    private Renderer areaRenderer;
    private Material originalMaterial;
    private Material glowMaterial;
    private bool playerInArea = false;
    private float timer = 0f;

    void Start()
    {
        // Obtener el Renderer del área
        areaRenderer = GetComponent<Renderer>();
        if (areaRenderer != null)
        {
            originalMaterial = areaRenderer.material;
            // Crear un material con resplandor azul
            glowMaterial = new Material(originalMaterial);
            glowMaterial.EnableKeyword("_EMISSION");
            glowMaterial.SetColor("_EmissionColor", glowColor);
        }
    }

    void Update()
    {
        if (playerInArea)
        {
            timer += Time.deltaTime;
            if (timer >= damageInterval)
            {
                ApplyDamage();
                timer = 0f;
            }
        }
    }

    private void ApplyDamage()
    {
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            PlayerHealth health = player.GetComponent<PlayerHealth>();
            if (health != null)
            {
                health.ReduceHealthByPercent(damagePercent);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerInArea = true;
            // Cambiar al material con resplandor azul
            if (areaRenderer != null && glowMaterial != null)
            {
                areaRenderer.material = glowMaterial;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            playerInArea = false;
            // Volver al material original
            if (areaRenderer != null && originalMaterial != null)
            {
                areaRenderer.material = originalMaterial;
            }
        }
    }
}