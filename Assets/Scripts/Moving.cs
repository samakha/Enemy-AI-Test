using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : BaseState
{
    private float horizontalInput;

    private MovingFM sm;

    public Moving(MovingFM stateMachine) : base("Moving", stateMachine)
    {
        sm = (MovingFM)stateMachine;

    } 


      public override void Enter( )
    {
        base.Enter();
        horizontalInput = 0f; 
    }
    public override void UPdatelogic()
    {
        base.UPdatelogic();
        horizontalInput = Input.GetAxis("Horizontal"); 
        if( Mathf.Abs( horizontalInput) < Mathf.Epsilon)
        {
            stateMachine.ChangeState(sm.idleState); 

        }


    }
    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        Vector2 velocity = sm.rb.velocity;
        velocity.x = horizontalInput * ((MovingFM)stateMachine).moveSpeed; 
    
    }




}
