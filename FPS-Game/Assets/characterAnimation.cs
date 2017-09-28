using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class characterAnimation : MonoBehaviour
{
    private CharacterController charcontroller;

    Vector3 horizontalvelocity;

    Animator chanimator;

	// Use this for initialization
	void Start ()
    {

        charcontroller = GetComponentInParent<CharacterController>();

        chanimator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
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
