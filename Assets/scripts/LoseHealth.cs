using UnityEngine;

public class LoseHealth : MonoBehaviour
{
    float damage = 10f;
    HealthSystem healthSystem;
    
    public void OnTriggerStay(Collider collision)
    {
        healthSystem.DamageRecieved(damage);
    }
}
