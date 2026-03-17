using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float collisionCooldown = 1f;

    const string hitString = "Hit";

    float cooldownTimer = 0f;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        cooldownTimer += Time.deltaTime;
    }
    

    void OnCollisionEnter(Collision collision)
    {
        if (cooldownTimer < collisionCooldown) return;

        anim.SetTrigger(hitString);
        cooldownTimer = 0f;
    }
}
