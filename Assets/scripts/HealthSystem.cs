[System.Serializable]
public class HealthSystem : StatSystem
{
    public int MaxHealth => MaxValue;
    public int CurrentHealth => CurrentValue;
}
