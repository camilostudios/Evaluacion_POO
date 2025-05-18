using UnityEngine;

public class ChargeHeatlh : MonoBehaviour
{
    private GenericHandler Handler;

    [SerializeField] int cure = 10;

    public void OnTriggerStay(Collider collision)
    {
        Handler.HealthSystem.AffectValue(cure);
    }
}
