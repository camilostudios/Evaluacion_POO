using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform spawnPoint; // Punto de origen del proyectil
    public float projectileSpeed = 10f; // Velocidad del proyectil

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Disparo con clic o botón asignado
        {
            LaunchProjectile();
        }
    }

    void LaunchProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = spawnPoint.forward * projectileSpeed;
        }
    }
}
