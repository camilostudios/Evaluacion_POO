using UnityEngine;

public class ChargeMana : MonoBehaviour
{
    public ManaSystem manaSystem;

    float boost = 10f;

    public void OnTriggerStay(Collider collision)
    {
        manaSystem.RestoreMana(boost);
    }
}
