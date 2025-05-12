using UnityEngine;

public class ChargeHeatlh : MonoBehaviour
{
    public HealthSystem healthSystem;

    float cure = 10f;

    public void OnTriggerStay(Collider collision)
    {
        healthSystem.RestoreHealth(cure);
    }
}
