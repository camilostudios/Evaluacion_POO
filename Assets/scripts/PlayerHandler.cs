using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public abstract class PlayerHandler : GenericHandler 
{
    [Header("Additional Stats")]
    [SerializeField] private ManaSystem manaSystem;
    [Space]
    [Header("Movement")]
    [SerializeField, Min(0)] private float speed;
    [SerializeField] private float gravity;
    [SerializeField] private Transform camera;
    [SerializeField] private float turnCalmTime = 0.1f;
    [SerializeField] float turnCalmVelocity;
    [Space]
    [Header("Skills")]
    [SerializeField] private Skill skill1, skill2, skill3;
    [Space]
    [Header("Required References")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject castZone;
    
    private CharacterController _controller;
    
    public ManaSystem ManaSystem => manaSystem;
    public Camera PlayerCamera => playerCamera;
    public GameObject CastZone => castZone;

    protected override void Awake()
    {
        base.Awake();
        
        manaSystem.Init();
        
        _controller = GetComponent<CharacterController>();
        
        skill1?.Init(this);
        skill2?.Init(this);
        skill3?.Init(this);
    }

    protected override void Update()
    {
        base.Update();
        
        PlayerMove();
        
        if(Input.GetButtonDown("Fire1") && skill1 != null && ResourceLeft() > skill1.Cost)
        {
            skill1.UseSkill();
        }

        if (Input.GetButtonDown("Fire2") && skill2 != null && ResourceLeft() > skill2.Cost)
        {
            skill2.UseSkill();
        }

        if (Input.GetButtonDown("Fire3") && skill3 != null && ResourceLeft() > skill3.Cost)
        {
            skill3.UseSkill();
        }
    }
    
    public abstract void UseResource(int cost);
    public abstract int ResourceLeft();

    private void PlayerMove() {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontalAxis, 0, verticalAxis).normalized;

        if (direction.magnitude >= 0.1f) 
        { 
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnCalmVelocity, turnCalmTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            _controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
