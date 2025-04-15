using UnityEngine;

public class PlayerHurtHandler : MonoBehaviour
{
    PlayerAnimation playerAnimation;
    HealthBar healthBar;
    int currentHealth;
    [SerializeField]int maxHealth = 50;

    void Awake()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
        healthBar = GetComponentInChildren<HealthBar>();
        currentHealth = maxHealth;
        healthBar.SetMax(maxHealth);
        healthBar.SetCurrent(maxHealth);
    }

    public void PlayerHurt(int damageAmount)
    {
        playerAnimation.HurtAnimation();

        currentHealth-= damageAmount;
        healthBar.SetCurrent(currentHealth);
    }
}   
