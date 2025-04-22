using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "MyData/WeaponData", order = 0)]
public class WeaponData : ScriptableObject 
{
    public int maxHealth;
    public int damage;
    public WeaponType WeaponType;
}

public enum WeaponType
{
    Melee = 0,
    Range = 1,
    Mage = 2
}
