using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class aiming : MonoBehaviour
{   
    [SerializeField] private CinemachineFreeLook aimCam;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            aimCam.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            aimCam.gameObject.SetActive(false);
        }
        
    }
}
