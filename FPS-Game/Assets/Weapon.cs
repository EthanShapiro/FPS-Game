using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
    public enum WeaponType_int {noWeapon = 0, pistol=1, assaultRifle01=2, assaultRifle=3, shotgun=4, sniperRifle=5, rifle=6, subMachinGun=7, rPG=8, miniGun=9, grenades=10, bow=11, melee=12}
    [SerializeField]private WeaponType_int weaponType;

	// Use this for initialization
	private void Start()
	{

	}
	// Update is called once per frame
	private void Update()
	{

	}
}