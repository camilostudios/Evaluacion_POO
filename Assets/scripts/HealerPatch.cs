using UnityEngine;

public class HealerPatch : Skills
{
    public float cure = 20f;
    
    HealerPatch healerPatch= new("HealerPatch", Sprite, 30, true);
    public override UseSkill()
    {
        HealthSystem.RestoreHealth(cure);
    }
}
