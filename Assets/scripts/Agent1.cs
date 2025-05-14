using UnityEngine;

public class Agent1 : MonoBehaviour
{
    PlayerHandler agente1 = new("Guerrero", 1f, 100f, 1f, 0f);
    public DoomRope doomRope = new("DoomRope", 15, true);
    public GoldenBullet goldenBullet = new("GoldenBullet", 3, true);
    public HealerPatch healerPatch = new("HealerPatch", 30, true);

    public Transform camera;
    public void Start()
    {
        agente1.currentHealth = agente1.maxHealth;
        goldenBullet.Cooldown = 0;
    }

    public void Update(){
        agente1.PlayerMove();
        
        if(Input.GetButtonDown("Fire1") && goldenBullet.Usable == true)
        {
            goldenBullet.UseSkill();
        }

        if (Input.GetButtonDown("Fire2") && doomRope.Usable == true)
        {
            doomRope.UseSkill();
        }

        if (Input.GetButtonDown("Fire3") && healerPatch.Usable == true)
        {
            healerPatch.UseSkill();
        }
    }
}
