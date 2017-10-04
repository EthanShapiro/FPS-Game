using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
    public enum WeaponType_int {noWeapon = 0, pistol=1, assaultRifle01=2, assaultRifle02=3, shotgun=4, sniperRifle=5, rifle=6, subMachinGun=7, rPG=8, miniGun=9, grenades=10, bow=11, melee=12}
    [SerializeField]private WeaponType_int weaponType;

    [SerializeField]private Transform gunBarrel;

    private void Start()
    {
        this.transform.rotation = Quaternion.Euler(0, 90, 90);
    }

    public Transform GetBarrelTransform()
    {
        return gunBarrel;
    }
}