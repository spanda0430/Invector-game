using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public GameObject[] selectSigns;

    [HideInInspector]
    public int selectedCharacter;

    private void Start()
    {
        Character1();
    }

    public void Character1()
    {
        selectSigns[0].SetActive(true);
        selectSigns[1].SetActive(false);
        selectSigns[2].SetActive(false);

        selectedCharacter = 0;
    }

    public void Character2()
    {
        selectSigns[0].SetActive(false);
        selectSigns[1].SetActive(true);
        selectSigns[2].SetActive(false);

        selectedCharacter = 1;
    }

    public void Character3()
    {
        selectSigns[0].SetActive(false);
        selectSigns[1].SetActive(false);
        selectSigns[2].SetActive(true);

        selectedCharacter = 2;
    }
}
