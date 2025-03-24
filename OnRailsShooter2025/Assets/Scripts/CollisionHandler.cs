using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destoryedVFX;

    void OnTriggerEnter(Collider other)
    {
        Instantiate(destoryedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
