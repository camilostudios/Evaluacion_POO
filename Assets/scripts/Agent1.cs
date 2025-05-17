using UnityEngine;

public class Agent1 : PlayerHandler
{
    public override void UseResource(int cost)
    {
        HealthSystem.AffectValue(-cost);
    }

    public override int ResourceLeft()
    {
        return HealthSystem.CurrentHealth;
    }
}