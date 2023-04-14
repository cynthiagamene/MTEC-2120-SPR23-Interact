using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAssetCamera : MonoBehaviour
{
    CinemachineVirtualCamera cam;

    void Reset()
    {
        cam = GetComponent<CinemachineVirtualCamera>();
        cam.Follow = GameObject.Find("PlayerCameraRoot").transform;
    }

}
