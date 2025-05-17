using UnityEngine;

public class ChargeMana : MonoBehaviour
{
    private GenericHandler Handler;
    
    [SerializeField] int boost = 10;

    public void OnTriggerStay(Collider collision)
    {
        //Handler.ManaSystem.AffectValue(boost);
    }
}
