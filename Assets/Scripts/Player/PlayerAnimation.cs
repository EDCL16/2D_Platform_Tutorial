using System;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        animator =  GetComponent<Animator>();
    }

    public void SetIsMoving(float xVelocity)
    {
        bool isMoving = Math.Abs(xVelocity) > 0.1f;
        animator.SetBool("IsMoving" , isMoving);
    }

    public void HurtAnimation()
    {
        animator.SetTrigger("Hurt");
    }
}
