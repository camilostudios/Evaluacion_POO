using UnityEngine;
using UnityEngine.UI;

public class PlayerStatus : MonoBehaviour
{
    public Slider manaSlider; // Referencia al Slider de Mana
    public Slider vidaSlider; // Referencia al Slider de Vida

    public float maxMana = 100f;
    public float maxVida = 100f;
    private float currentMana;
    private float currentVida;

    private void Start()
    {
        currentMana = maxMana;
        currentVida = maxVida;

        UpdateSliders();
    }

    private void UpdateSliders()
    {
        manaSlider.value = currentMana / maxMana;
        vidaSlider.value = currentVida / maxVida;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AreaVida")) // Área que restaura vida
        {
            currentVida = Mathf.Clamp(currentVida + 20f, 0f, maxVida); // Recupera vida
            UpdateSliders();
        }
        else if (other.CompareTag("AreaMana")) // Área que consume maná
        {
            currentMana = Mathf.Clamp(currentMana - 20f, 0f, maxMana); // Reduce maná
            UpdateSliders();
        }
    }
}
