using UnityEngine;

public class Agent1 : PlayerHandler
{
    PlayerHandler agente1 = new("Guerrero", 1f);

    public void Update(){
        PlayerHandler.PlayerMove();
        
        if(Input.GetButtonDown("")){
            UseSkill(healerPatch);
            UseSkill(goldenBullet);
            UseSkill(DoomRope);
        }
    }
}
