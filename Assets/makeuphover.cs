﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeuphover : MonoBehaviour
{
    public GameObject textss;
    // Start is called before the first frame update
    void Start()
    {
        textss.SetActive(false);
    }
    public void OnMouseOver()
    {

        textss.SetActive(true);
    }

    public void OnMouseExit()
    {
        textss.SetActive(false);
    }
}
