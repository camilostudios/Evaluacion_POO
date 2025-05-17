using UnityEngine;

public class Unplayable : GenericHandler
{
    GenericHandler enemy = new("Muñeco de prueba");
    
    public void Update()
    {        
        if(currentHealth < minHealth)
        {
            Destroy(enemy);
        }
    }
    
    void Destroy(GenericHandler enemy)
    {
        Destroy(enemy);
    }
}
