using UnityEngine;

public class Character_Controller : MonoBehaviour {
    public AnimationCharacter a_Character;
    public Transform Chica;
    [Header("Movement")]
    public float SpeedZ;
    public float SpeedX;
    public CharacterController controller;
    [Range(0.5f, 20)] public float walkSpeed,strafeSpeed;
    private Vector3 velocity = Vector3.zero;

    void Update() {
        Movement();
    }
    private void Movement() {
        float _InputZ=Input.GetAxisRaw("Vertical");
        float _InputX=Input.GetAxisRaw("Horizontal");
        //bool IsWalk;
        Chica.transform.rotation= Quaternion.Euler(0,-90*_InputX,0);
        SpeedZ=_InputZ;
        SpeedX=_InputX;
        if(SpeedZ<0.1){
            transform.localScale=new Vector3(1,1,-1);
            }
        if(SpeedZ>0.1){
            transform.localScale=new Vector3(1,1,1);
            }
        
    

        velocity.z =_InputZ * walkSpeed;
        velocity.x =_InputX* strafeSpeed;
        velocity = transform.TransformDirection(velocity);
        velocity.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        a_Character.Animate( SpeedZ, SpeedX);
    }
}
