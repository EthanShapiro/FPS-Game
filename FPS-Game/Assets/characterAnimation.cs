using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class characterAnimation : MonoBehaviour {

    public GameObject FPSController;

    private CharacterController charcontroller;

    Vector3 horizontalvelocity;

    Animator chanimator;

    Rigidbody rb;

	// Use this for initialization
	void Start () {

        charcontroller = GetComponentInParent<CharacterController>();

        chanimator = this.GetComponent<Animator>();

        rb = this.GetComponentInParent<Rigidbody>();

     
 
	}
	
	// Update is called once per frame
	void Update () {

        horizontalvelocity = new Vector3(charcontroller.velocity.x, 0, charcontroller.velocity.z);

        float horizontalspeed = horizontalvelocity.magnitude;

        chanimator.SetFloat("Speed_f", horizontalspeed);


        if (charcontroller.velocity.y >= 0.1)
        {
            chanimator.SetBool("Jump_b", true);
        }


        else if (charcontroller.velocity.y == 0)
        {
            chanimator.SetBool("Jump_b", false);
        }


    }
}
