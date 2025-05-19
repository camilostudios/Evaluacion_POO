using UnityEngine;

[CreateAssetMenu(fileName = "New DoomRope", menuName = "Skills/DoomRope")]
public class DoomRope : Skill
{
    [Header("Properties")]
    [SerializeField] GameObject damageZone;
    
    public override void UseSkill()
    {
        base.UseSkill();

        Transform castZone = Handler.CastZone.transform;
        Instantiate(damageZone,castZone.transform.position, castZone.transform.rotation);
    }
}
