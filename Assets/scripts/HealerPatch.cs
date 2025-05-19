using UnityEngine;

[CreateAssetMenu(fileName = "New HealerPatch", menuName = "Skills/HealerPatch")]
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
