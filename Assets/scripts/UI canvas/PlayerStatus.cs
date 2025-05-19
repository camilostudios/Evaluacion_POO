using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public Slider manaSlider; // Referencia al Slider de Mana
    public Slider vidaSlider; // Referencia al Slider de Vida

    private ManaSystem manaSystem;
    private HealthSystem healthSystem;

    private void Update()
    {
        UpdateSliders();
    }

    private void UpdateSliders()
    {
        if (manaSystem != null && healthSystem != null)
        {
            manaSlider.value = manaSystem.CurrentMana;
            vidaSlider.value = healthSystem.CurrentHealth;
        }
    }
}
