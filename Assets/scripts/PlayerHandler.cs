using UnityEngine;

public class PlayerHandler : genericHandler 
{
    public float speed;
    public float gravity;
    public CharacterController controller;
    public Camera camera;

    public genericHandler playable = new("Players");
    
    public PlayerHandler(){}
    public PlayerHandler(string name, float speed, float maxHealth, float minHealth, float currentHealth)
    {
        this.name = name;
        this.speed = speed;
        healthSystem.maxHealth = maxHealth;
        this.minHealth = minHealth;
        this.currentHealth = currentHealth;
    }

    public void PlayerMove(){
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;
    }
}
