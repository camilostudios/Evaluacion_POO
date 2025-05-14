using UnityEngine;

public class GoldenBullet : Skills
{
    float damage = 20f;
    HealthSystem healthSystem;
    public Camera camera;
    Agent1 camera1 = camera;
    Agent2 camera2 = camera;
    
    public GoldenBullet(string name, int Cooldown, bool Usable)
    {
        this.name = name;
        this.Cooldown = Cooldown;
        this.Usable = Usable;
    }
    
    public override void UseSkill()
    {
        camera.GetComponent<Transform>();
        RaycastHit raycastHit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out raycastHit)){
            healthSystem.DamageRecieved(damage);
        }
    }

    
}
