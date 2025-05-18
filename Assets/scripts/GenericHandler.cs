using UnityEngine;

public abstract class GenericHandler : MonoBehaviour
{
    [Header("Base Stats")]
    [SerializeField] private HealthSystem healthSystem;
    
    public HealthSystem HealthSystem => healthSystem;

    protected virtual void Awake()
    {
        healthSystem.Init();
    }
    protected virtual void Start() {}
    protected virtual void Update() {}
}
