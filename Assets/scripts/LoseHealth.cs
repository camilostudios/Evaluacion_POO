using UnityEngine;

public class LoseHealth : MonoBehaviour
{
    private GenericHandler Handler;
    
    [SerializeField]int damage = 10;
    
    public void OnTriggerStay(Collider collision)
    {
        Handler.HealthSystem.AffectValue(-damage);
        print("esta interactuando");
    }
}
