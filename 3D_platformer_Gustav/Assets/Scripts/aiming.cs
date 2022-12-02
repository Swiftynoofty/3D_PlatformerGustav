using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class aiming : MonoBehaviour
{   
    [SerializeField] private GameObject aimCam;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
            aimCam.gameObject.SetActive(true);
        }
        else
        {
            aimCam.gameObject.SetActive(false);
        }
        
    }
}
