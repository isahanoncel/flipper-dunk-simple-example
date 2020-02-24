using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    JointMotor2D motor = new JointMotor2D();
     public float torque,motorSpeed;
    void Update()
    {
    if(Input.GetKey(KeyCode.Mouse0) && this.gameObject.transform.rotation.z>-0.50f)
        {
        motor.motorSpeed = motorSpeed;
        motor.maxMotorTorque = torque;
        }
        else if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            motor.motorSpeed = -motorSpeed;
          motor.maxMotorTorque = torque;
        }
        gameObject.GetComponent<HingeJoint2D>().motor = motor;
    }
}
