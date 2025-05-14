using UnityEngine;

public class PlayerHandler : genericHandler 
{
    public float speed;
    public float gravity;
    public CharacterController controller;
    public Transform camera;

    public genericHandler playable = new("Players");
    
    public PlayerHandler(){}
    public PlayerHandler(string name, float speed, float maxHealth, float minHealth, float currentHealth)
    {
        this.name = name;
        this.speed = speed;
        healthSystem.maxHealth = maxHealth;
        healthSystem.minHealth = minHealth;
        healthSystem.currentHealth = currentHealth;
    }
    
    public void PlayerMove(){
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;

        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;

        Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        controller.Move(moveDirection.normalized * speed * Time.deltaTime);

    }
}
