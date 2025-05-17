using UnityEngine;

public class DoomRope : Skill
{
    public float damage = 30f;
    public GameObject damageZone;
    
    public override void UseSkill()
    {
        base.UseSkill();
        
        GameObject.Instantiate(damageZone);
    }
}
