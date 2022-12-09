using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNameScript : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = GameObject.Find("UserName").GetComponent<UserName>().userName;
    }
}
