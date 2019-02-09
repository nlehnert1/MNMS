using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovingObject
{

    public int playerDamage;

    private Animator animator;
    private Transform target;
    private bool skipMove;


    // Start is called before the first frame update
    protected override void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectsWithTag("Player").transform;
        base.Start();
    }

    private T GetComponent<T>()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    protected override void AttemptMove<T>(int xDir, int yDir)
    {
        if (skipMove)
        {
            skipMove = false;
            return;
        }

        base.AttemptMove<T>(xDir, yDir);

        skipMove = true;
    }

    public void MoveEnemy()
    {
        int xDir = 0;
        int yDir = 0;

        if (Mathf.Abs(target.position.x - Transform.position.x) < float.Epsilon)
        {
            yDir = target.position.y > Transform.position.y ? 1 : -1;
        }
        else
            xDir = target.position.x > Transform.position.x ? 1 : -1;

        AttemptMove<UnityEditor.Build.Player>(xDir, yDir);
    }
}
