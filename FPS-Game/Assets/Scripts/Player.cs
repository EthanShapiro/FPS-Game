using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour 
{
    public Weapon weapon;
    public int health = 10;

    // Use this for initialization
    private void Start()
	{
        weapon = GetComponentInChildren<Weapon>();
	}
	// Update is called once per frame
	private void Update()
	{
        bool shoot = Input.GetMouseButtonUp(0);
        if (shoot)
        {
            CmdRaycastShot();
        }
	}

    [Command]
    private void CmdRaycastShot()
    {
        Ray shot = new Ray(weapon.GetBarrelTransform().position, weapon.GetBarrelTransform().forward);
        RaycastHit[] hits = Physics.RaycastAll(shot, 20f);
        for (int i = 0; i < hits.Length; i++)
        {
            Player playerController = hits[i].transform.GetComponent<Player>();
            if (playerController)
            {
                playerController.health--;
            }
        }
    }
}