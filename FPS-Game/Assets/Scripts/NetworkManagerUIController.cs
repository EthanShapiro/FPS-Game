using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerUIController : NetworkManager 
{
    [Header("UI Properties")]
    [SerializeField] private Canvas ui;

    public override void OnStartClient(NetworkClient client)
    {
        ui.gameObject.SetActive(false);
    }

    public override void OnStopClient()
    {
        ui.gameObject.SetActive(true);
    }

    public override void OnStartHost()
    {
        ui.gameObject.SetActive(false);
    }

    public override void OnStopHost()
    {
        ui.gameObject.SetActive(true);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
    }

    // Use this for initialization
    private void Start()
	{

	}
	// Update is called once per frame
	private void Update()
	{

	}
}