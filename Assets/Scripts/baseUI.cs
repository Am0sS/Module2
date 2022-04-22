using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseUI : MonoBehaviour
{

    public GameObject spaceToStart;
    public GameObject asteroidsText;
    public GameObject controlsText;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.H)) {
            controlsText.SetActive(true);
        }
        else
        {
            controlsText.SetActive(false);
        }


    }
}
