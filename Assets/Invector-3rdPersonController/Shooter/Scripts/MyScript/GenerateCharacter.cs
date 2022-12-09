using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCharacter : MonoBehaviour
{
    public GameObject character;
    public int childCnt;
    public Transform parentOfCharacter;

    private int selectedCharacter;
    private int[] availableMesh;

    // Start is called before the first frame update
    void Start()
    {
        selectedCharacter = GameObject.Find("UserName").GetComponent<UserName>().selectedCharacter;

        if (selectedCharacter == 0)
        {
            availableMesh = new int [2] {4, 6};
        } else if (selectedCharacter == 1)
        {
            availableMesh = new int[7] {0,1,6,9,13,15,16};
        } else
        {
            availableMesh = new int[17] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17};
        }

        for (int i = 0; i < childCnt; i++)
            character.transform.GetChild(i).gameObject.SetActive(false);

        for(int j = 0; j < availableMesh.Length; j++)
            character.transform.GetChild(availableMesh[j]).gameObject.SetActive(true);
        //         GameObject Go = Instantiate(characters[selectedCharacter], parentOfCharacter);
        //         Go.transform.localPosition = new Vector3(0, 0, 0);
        //         Go.name = "Man_01";

        //         for (int i = 0; i < characters.Length; i++)
        //         {
        //             if (i != selectedCharacter)
        //                 characters[i].SetActive(false);
        //         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
