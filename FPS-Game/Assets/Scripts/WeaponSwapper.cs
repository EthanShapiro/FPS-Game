using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WeaponSwapper : MonoBehaviour 
{
    private Weapon[] weapons = new Weapon[15]; 

	// Use this for initialization
	private void Start()
	{
        weapons = GetComponentsInChildren<Weapon>();
	}

	// Update is called once per frame
	private void Update()
	{

	}
}