using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;

    void OnParticleCollision(GameObject other)
    {
        Instantiate(destoryedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
