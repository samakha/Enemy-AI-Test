using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine : MonoBehaviour
{
    BaseState currentState; 
    void Start()
    {
        currentState = GetInitialState(); 
    }

    // Update is called once per frame
    void Update()
    {
        if ( currentState !=null )
        {
            currentState.UPdatelogic(); 
        }
    }
    private void LateUpdate()
    {
        if( currentState !=null )
        {
            currentState.UpdatePhysics(); 
        }
    }

    public void ChangeState( BaseState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter(); 
    }
    protected virtual BaseState GetInitialState( )
    {
        return null; 
    }
    public void OnGUI()
    {
        string name = currentState != null ? currentState.name :  " no state "; 


    }
}
