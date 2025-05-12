using UnityEngine;

public class Unplayable : genericHandler
{
    genericHandler enemy = new("Muñeco de prueba");
    
    public void Update()
    {        
        if(currentHealth < minHealth)
        {
            Destroy(enemy);
        }
    }
    
    void Destroy(genericHandler enemy)
    {
        Destroy(enemy);
    }
}
