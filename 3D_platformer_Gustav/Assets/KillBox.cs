using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.localPosition = new Vector3(0f, -10.5f, 62.9f);
        }

    }
}