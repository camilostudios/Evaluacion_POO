using UnityEngine;

public class HealerPatch : Skill
{
    [Header("Properties")]
    [SerializeField] int cure = 20;
    
    public override void UseSkill()
    {
        base.UseSkill();
        
        Handler.HealthSystem.AffectValue(cure);
    }
}
