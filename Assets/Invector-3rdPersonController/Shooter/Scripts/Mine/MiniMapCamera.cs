using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    public float miniCameraHeight = 30;

    private GameObject Go;
    private void Update()
    {
        Go = GameObject.FindWithTag("Player");
        if (Go != null)
        {
            transform.position = Go.transform.position + new Vector3(0, miniCameraHeight, 0);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
