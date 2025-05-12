using UnityEngine;

public class genericHandler : HealthSystem
{
    public string name;

    public HealthSystem healthSystem = new(100f, 1f, 100f);

    public genericHandler() {}
    public genericHandler(string name)
    {
        this.name = name;
    }
}
