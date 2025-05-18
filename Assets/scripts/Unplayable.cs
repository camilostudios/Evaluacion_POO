using UnityEngine;

public class Unplayable : GenericHandler
{
    
    protected override void Update()
    {        
        if(HealthSystem.CurrentHealth == 0)
        {
            Destroy();
        }
    }
    
    void Destroy()
    {
        Destroy(GameObject.FindGameObjectWithTag("Unplayable"));
    }
}
