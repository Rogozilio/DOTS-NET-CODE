using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRandom : StateMachineBehaviour
{
    public int StatesCount;
    //OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger("Modify", Random.Range(0, StatesCount));
    }

  
}
