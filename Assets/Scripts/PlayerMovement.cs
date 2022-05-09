using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Profiling; 

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    private bool isGround; 
    public int facingDirection = 1;

    private void Awake()
    {
        Debug.Log("Awake "); 
    }
    private void Start()
    {
        Debug.Log("Start "); 
    }

    void Update()
    {
      if( Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Animator>().SetBool("Attack", true); 
        }
      else
        {
            GetComponent<Animator>().SetBool("Attack", false);
        }
    }
    
     
   
}
