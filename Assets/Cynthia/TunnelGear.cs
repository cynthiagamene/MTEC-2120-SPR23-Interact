using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;
using Kvant;

public class TunnelGear : MonoBehaviour
{
    public GameObject tunnel;
    private Tunnel _tunnel; 
    public ReaktorLink reaktor;
    public float tunnelRadius = 100f; 

    void Awake()
    {
        reaktor.Initialize(this);
        _tunnel = tunnel.GetComponent<Tunnel>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTunnel(reaktor.Output +tunnelRadius); 
    }


    void UpdateTunnel(float param)
    {
        _tunnel.radius = param;
        _tunnel.Reset();
    }

}
