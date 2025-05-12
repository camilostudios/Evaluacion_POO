using UnityEngine;

public class HealthSystem
{
    public float maxHealth;
    public float minHealth;
    public float currentHealth;

    public HealthSystem(){}
    public HealthSystem(float maxHealth, float minHealth, float currentHealth)
    {
        this.maxHealth = maxHealth;
        this.minHealth = minHealth;
        this.currentHealth = currentHealth;
    }
    public float RestoreHealth(float cure){
        currentHealth += cure;
        return currentHealth;
    } 

    public float DamageRecieved(float damage)
    {
        currentHealth -= damage;
        return currentHealth;
    }
}
