using UnityEngine;

public abstract class Skills
{
    public string name;
    public int Cooldown;
    public bool Usable;

    public abstract void UseSkill();
}
