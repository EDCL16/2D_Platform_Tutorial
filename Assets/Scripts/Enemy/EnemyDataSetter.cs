using UnityEngine;

public class EnemyDataSetter : MonoBehaviour
{
    [SerializeField] EnemyData enemyData;

    EnemyHealth enemyhealth;
    EnemyHurtPlayer enemyHurtPlayer;
    
    void Awake()
    {
        enemyhealth = GetComponentInChildren<EnemyHealth>();//從子物件找腳本
        enemyHurtPlayer = GetComponent<EnemyHurtPlayer>();
    }

    void Start()
    {
        enemyhealth.SetUpHealthBar(enemyData.maxHealth);
        enemyHurtPlayer.SetEnemyDamage(enemyData.damage);
    }
}
