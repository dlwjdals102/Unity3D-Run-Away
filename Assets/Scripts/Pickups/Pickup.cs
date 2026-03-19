using UnityEngine;

public abstract class Pickup : MonoBehaviour
{

    protected PlayerCollisionHandler playerCollisionHandler;

    [SerializeField] float rotationSpeed = 100f;

    const string playerString = "Player";

    void Awake()
    {
        playerCollisionHandler = FindFirstObjectByType<PlayerCollisionHandler>();
    }

    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerString))
        {
            OnPickup();
            Destroy(gameObject);
        }
    }

    protected abstract void OnPickup();
}
