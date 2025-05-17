using UnityEngine;

public class Unplayable : GenericHandler
{
 
    public void Update()
    {        
        if(currentHealth = 0)
        {
            Destroy();
        }
    }
    
    void Destroy()
    {
        Destroy(GameObject.FindGameObjectWithTag("Unplayable"));
    }
}
