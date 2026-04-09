using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator Animator;

    private float cooldown = GameParameters.PlayerAttackCooldown;
    private float timer;

    public void Attack()
    {
        if (timer <= 0)
        {
            Animator.SetBool("IsAttacking", true);
            timer = cooldown;
        }
    }

    public void FinishAttacking()
    {
        Animator.SetBool("IsAttacking", false);
    }
    
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}
