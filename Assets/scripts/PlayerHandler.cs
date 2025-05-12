using UnityEngine;

public class PlayerHandler : genericHandler 
{
    public float speed;
    public float gravity;
    public CharacterController controller;
    public Camera camera;

    public DoomRope doomRope = new("DoomRope", 15, true);
    public GoldenBullet goldenBullet = new("GoldenBullet", 3, true);
    public HealerPatch healerPatch = new("HealerPatch", 30, true);
    public PlayerHandler(string name, float speed, float maxHealth, float minHealth, float currentHealth)
    {
        this.name = name;
        this.speed = speed;
        this.maxHealth = maxHealth;
        this.minHealth = minHealth;
        this.currentHealth = currentHealth;
    }

    public void PlayerMove(){
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
    }
}
