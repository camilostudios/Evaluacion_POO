using UnityEngine;

[CreateAssetMenu(fileName = "New GoldenBullet", menuName = "Skills/GoldenBullet")]
public class GoldenBullet : Skill
{
    [Header("Properties")]
    [SerializeField] private int damage = 20;
    
    public override void UseSkill()
    {
        base.UseSkill();
        
        Transform cameraTrans = Handler.PlayerCamera.transform;
        
        if(Physics.Raycast(cameraTrans.position, cameraTrans.forward, out RaycastHit raycastHit)){
            Handler.HealthSystem.AffectValue(-damage);
        }
    }
}
