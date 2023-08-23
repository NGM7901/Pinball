using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedalcontrol : MonoBehaviour
{
    public KeyCode input;
	private HingeJoint hinge;

	private void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring = 2000;
        }
        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }
}
