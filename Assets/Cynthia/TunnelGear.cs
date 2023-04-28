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
    public GameObject player; // Reference to the player object
    public Color newColor; // The new color to assign to the player

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
        // Check for keyboard input and change player color accordingly
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.GetComponent<Renderer>().material.color = newColor;
        }
    }


    void UpdateTunnel(float param)
    {
        _tunnel.radius = param;
        _tunnel.Reset();
    }

}
