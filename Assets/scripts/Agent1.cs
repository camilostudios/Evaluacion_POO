using UnityEngine;

public class Agent1 : PlayerHandler
{
    PlayerHandler agente1 = new("Guerrero", 1f, 100f, 1f, 0f);
    public void Start()
    {
        currentHealth = maxHealth;
        goldenBullet.Cooldown = 0;
    }

    public void Update(){
        PlayerHandler.PlayerMove();
        
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
            healerPatch.UseSkill(healerPatch);
        }
    }
}
