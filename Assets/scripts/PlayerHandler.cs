using UnityEngine;

[CreateAssetMenu(fileName = "PlayerHandler", menuName = "Scriptable Objects/PlayerHandler")]
public class PlayerHandler : ScriptableObject
{
    public float speed;
    public float gravity;
    public CharacterController controller;
}
