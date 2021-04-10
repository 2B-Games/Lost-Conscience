using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  //  public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    public float JumpForce;


    void Update()
    {
       // Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
      transform.position +=
            (transform.forward * Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime) + 
            (transform.right * Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime);
        
    }
}
