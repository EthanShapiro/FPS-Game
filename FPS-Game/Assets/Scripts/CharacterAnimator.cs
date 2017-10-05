using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class WeaponIdle_Floats
{
    public static float[] noWeaponAll = { 0f, 0f };
    public static float[] pistolIdle = { 0f, 0f };
    public static float[] pistolWalk = { 0f, 0f };
    public static float[] pistolRun = { 0f, 0.2f };
    public static float[] grenadeIdle = { 0f, 0f };
    public static float[] allWeaponsIdle = { 0f, 0.6f };
    public static float[] allWeaponsWalk = { 0f, 0.6f };
    public static float[] allWeaponsRun = { 0.3f, 0.6f };
}

public class CharacterAnimator : MonoBehaviour
{
    public enum IdleAnimations_int { noramlidle=0, crossedArms=1, handsOnHips=2, checkWatch=3, sexyDance=4, smoking=5, salute=6, wipeMount=7, leaningAgainstWall=8, sittingOnGround=9 }
    public enum DeathTypes_int { forward = 0, backward = 1 };
    public enum MeleeType_int { stab = 0, oneHanded = 1, twoHanded = 2 };

    private CharacterController charcontroller;

    private Animator chanimator;

	// Use this for initialization
	void Start ()
    {
        charcontroller = GetComponentInParent<CharacterController>();

        chanimator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	private void Update ()
    {
        Vector3 localHorizontalVelocity = transform.InverseTransformDirection(charcontroller.velocity);
        localHorizontalVelocity = new Vector3(localHorizontalVelocity.x, 0, localHorizontalVelocity.z);

        float horizontalspeed = localHorizontalVelocity.magnitude;

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

    public void PlayerDie(DeathTypes_int deathType)
    {

    }

    public void SetWeaponType(Weapon.WeaponType_int weaponType)
    {

    }

}
