using UnityEngine;

public class Agent2 : PlayerHandler
{
    public override void UseResource(int cost)
    {
        ManaSystem.AffectValue(-cost);
    }

    public override int ResourceLeft()
    {
        return ManaSystem.CurrentMana;
    }
}
