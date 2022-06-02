using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCombat : MonoBehaviour
{

    public Animator animator;
    public Transform attackHitBox;

    public float attackRange = 0.7f;
    public LayerMask enemyLay;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }
}
