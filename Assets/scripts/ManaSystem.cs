using UnityEngine;

public class ManaSystem
{
    public float minMana;
    public float maxMana;
    public float currentMana;
    
    public ManaSystem(){}
    public ManaSystem(float maxMana, float minMana, float currentMana)
    {
        this.maxMana = maxMana;
        this.minMana = minMana;
        this.currentMana = currentMana;
    }
    public float RestoreMana(float boost){
        currentMana += boost;
        return currentMana;
    } 

    //public float ManaConsumed(float damage)
    //{
        //currentHealth -= damage;
        //return currentHealth;
    //}
}
