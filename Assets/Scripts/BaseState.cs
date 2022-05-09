using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState  
{
    public  string name;  // state 
    protected FiniteStateMachine stateMachine; 

    public BaseState ( string name , FiniteStateMachine stateMachine) {  }

    public virtual void Enter()  { }
    public virtual void UPdatelogic()  { }
    public virtual void UpdatePhysics()  { }
    public virtual void Exit()  { }
}
