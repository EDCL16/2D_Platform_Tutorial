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
        healthBar.SetCurrent(maxHealth);
        healthBar.SetMax(maxHealth);
    }

    public void HandlePlayerHurt(int damageAmount)
    {
        playerAnimation.HurtAnimation();

        currentHealth-= damageAmount;
        healthBar.SetCurrent(currentHealth);
    }
}   
