using UnityEngine;

public class Unplayable : genericHandler
{
    genericHandler enemy = new("Muñeco de prueba");
    public void Update()
    {
        DamageRecieved();
        
        if(currentHealth <= minHealth)
        {
            Destroy(enemy);
        }
    }
    
    void Destroy(genericHandler enemy)
    {
        Destroy(enemy);
    }

    void DamageRecieved(float damage)
    {
        currentHealth -= damage;
    }
}
