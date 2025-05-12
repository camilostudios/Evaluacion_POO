using UnityEngine;

public class DoomRope : Skills
{
    public float damage = 30f;
    
    public DoomRope(string name, int Cooldown, bool Usable)
    {
        this.name = name;
        this.Cooldown = Cooldown;
        this.Usable = Usable;
    }
    
    public override void UseSkill()
    {
        
    }
}
