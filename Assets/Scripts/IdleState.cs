using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{

    public IdleState ( FiniteStateMachine fsm ) : base ( "Idle", fsm) {  }
    private float horizontalInput;
    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f; 
    }

    // Update is called once per frame
    public override void UPdatelogic()
    {
        base.UPdatelogic();
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (Mathf.Abs(horizontalInput) > Mathf.Epsilon)
        {

        }
         //   stateMachine.ChangeState(Moving); 
    }
}
