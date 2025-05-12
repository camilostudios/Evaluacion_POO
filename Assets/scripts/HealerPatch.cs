using UnityEngine;

public class HealerPatch : Skills
{
    public float cure = 20f;
    
    public HealerPatch(string name, int Cooldown, bool Usable)
    {
        this.name = name;
        this.Cooldown = Cooldown;
        this.Usable = Usable;
    }
    
    public override void UseSkill()
    {
        HealthSystem.RestoreHealth(cure);
    }
}
