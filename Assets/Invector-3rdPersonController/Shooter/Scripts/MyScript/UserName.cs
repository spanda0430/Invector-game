using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserName : MonoBehaviour
{
    [HideInInspector]
    public string userName;

    [HideInInspector]
    public int selectedCharacter = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Text>().text = GameObject.Find("userNameTemp").GetComponent<Text>().text;
    }

    public void SaveUserName()
    {
        userName = GameObject.Find("userName1").GetComponent<InputField>().text;
        selectedCharacter = GameObject.Find("Characters").GetComponent<Characters>().selectedCharacter;
    }

}
