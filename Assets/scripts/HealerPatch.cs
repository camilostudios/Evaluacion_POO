using UnityEngine;

public class HealerPatch : Skill
{
    float cure = 20f;
    HealthSystem healthSystem;
    
    public HealerPatch(string name, int Cooldown, bool Usable)
    {
        this.name = name;
        this.Cooldown = Cooldown;
        this.Usable = Usable;
    }
    
    public override void UseSkill()
    {
        healthSystem.RestoreHealth(cure);
    }
}
