using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFM : FiniteStateMachine
{
    public Rigidbody2D rb;
    public float moveSpeed; 
    [HideInInspector]
    public IdleState idleState;
    [HideInInspector]
    public Moving movingState;

    public float speed = 4f; 
    void Awake()
    {
        idleState = new IdleState(this);
        movingState = new Moving(this); 
    }

    // Update is called once per frame
     protected override BaseState GetInitialState( )
    {
        return idleState; 
    }
  
}
