using UnityEngine;

[CreateAssetMenu(fileName = "New DoomRope", menuName = "Skills/DoomRope")]
public class DoomRope : Skill
{
    [Header("Properties")]
    [SerializeField] GameObject damageZone;
    [SerializeField] GameObject CastZone;
    
    public override void UseSkill()
    {
        base.UseSkill();
        
        Instantiate(damageZone,CastZone.transform.position, CastZone.transform.rotation);
    }
}
