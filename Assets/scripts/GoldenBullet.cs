using UnityEngine;

public class GoldenBullet : Skills
{
    public float damage = 20f;
    
    public GoldenBullet(string name, int Cooldown, bool Usable)
    {
        this.name = name;
        this.Cooldown = Cooldown;
        this.Usable = Usable;
    }
    
    public override void UseSkill()
    {
        RaycastHit raycastHit;
        if(Physics.Raycast(camera.transform.position, out raycastHit)){
            DamageRecieved(damage);
        }
    }
}
