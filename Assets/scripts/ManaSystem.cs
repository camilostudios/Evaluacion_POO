using System.Threading.Tasks;
using UnityEngine;

public enum ManaFlowType
{
    Instant,
    ByTime
}

[System.Serializable]
public class ManaSystem : StatSystem
{
    [SerializeField] private ManaFlowType manaFlowType;
    [SerializeField, Min(1)] private int rechargeValuePerSecond;
    
    public int MaxMana => MaxValue;
    public int CurrentMana => CurrentValue;

    public override void AffectValue(int value)
    {
        switch (manaFlowType)
        {
            case ManaFlowType.Instant:
                base.AffectValue(value);
                break;
            case ManaFlowType.ByTime:
                AffectByTime(value);
                break;
        }
    }

    private async void AffectByTime(int value)
    {
        int addedValue = 0;

        while (addedValue < value)
        {
            addedValue += rechargeValuePerSecond;
            base.AffectValue(rechargeValuePerSecond);
            
            await Task.Delay(1000);
        }
    }
}
