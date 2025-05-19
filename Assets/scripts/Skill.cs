using UnityEngine;

public abstract class Skill : ScriptableObject
{
    [Header("Base Properties")]
    [SerializeField] private string skillName;
    [SerializeField] private int cooldown;
    [SerializeField] private int cost;

    protected PlayerHandler Handler { get; private set; }
    public int Cost => cost;
    public int Cooldown => cooldown;

    public void Init(PlayerHandler handler)
    {
        if (Handler) return;
        
        Handler = handler;
    }

    public virtual void UseSkill()
    {
        if (!Handler) return;
        if(Handler.ResourceLeft() < Cost) return;
        
        Handler.UseResource(Cost);
    }
}
