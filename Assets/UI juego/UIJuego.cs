using UnityEngine;
using UnityEngine.UIElements;

public class UIJuego : MonoBehaviour
{
    UIDocument menu;
    // botones
    Button jugar;
    Button opciones;
    Button vidaButton;
    Button manaButton;

    // sliders
    Slider vidaSlider;
    Slider manaSlider;

    private void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;

        // Inicializar botones
        jugar = root.Q<Button>("jugar");
        opciones = root.Q<Button>("opciones");
        vidaButton = root.Q<Button>("vida");
        manaButton = root.Q<Button>("mana");

        // Inicializar sliders
        vidaSlider = root.Q<Slider>("vidaSlider");
        manaSlider = root.Q<Slider>("manaSlider");

        // Configurar sliders (valores iniciales)
        vidaSlider.value = 100; // Vida inicial
        manaSlider.value = 50;  // Mana inicial
    }
}