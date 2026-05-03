using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCharacter : MonoBehaviour{
    public Animator animator;
    
   //public void Animate(bool Speed){
   //     animator.SetBool("Walk", Speed);
   // }

    public void Animate(float SX, float SZ){
        animator.SetFloat("SpeedX",SX);
        animator.SetFloat("SpeedZ",SZ);

    }
}
