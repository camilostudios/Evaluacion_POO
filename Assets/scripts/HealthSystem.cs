using UnityEngine;

public class HealthSystem
{
    public float maxHealth;
    public float minHealth;
    public float currentHealth;

    public float RestoreHealth(float cure){
        currentHealth += cure;
        return currentHealth;
    } 
}
