using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "MyData/EnemyData", order = 0)]
public class EnemyData : ScriptableObject 
{
    public int maxHealth;
    public int damage;
}
