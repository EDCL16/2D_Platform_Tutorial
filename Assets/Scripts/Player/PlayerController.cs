using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int number = 11;
    bool isTuesday = true;
    void Start()
    {
       switch(number)
       {
        case  5:
            Debug.Log("5");
            break; 
        case   10:
            Debug.Log("10");
            break; 
        default : 
            Debug.Log("no case found");
            break; 
        }
    }
}
