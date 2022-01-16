using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniWithAnimator : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();    
    }

    public void Open()
    {
        animator.SetBool("isOpen", true);
    }

    public void Close()
    {
        animator.SetBool("isOpen", false);
    }

}
