using UnityEngine;

[System.Serializable]
public abstract class StatSystem
{
    [SerializeField] private int maxValue;
    
    [SerializeField] private int _currentValue;
    
    protected int MaxValue => maxValue;
    protected int CurrentValue => _currentValue;

    public void Init() => _currentValue = maxValue;
    
    public virtual void AffectValue(int value)
    {
        _currentValue = Mathf.Clamp(_currentValue + value, 0, MaxValue);
    }
}
