using UnityEngine;

public class PlayerHandler : genericHandler
{
    public float speed;
    public float gravity;
    public CharacterController controller;

    public PlayerHandler(string name, float speed)
    {
        this.name = name;
        this.speed = speed;
    }

    protected PlayerMove(){
        
    }
}
