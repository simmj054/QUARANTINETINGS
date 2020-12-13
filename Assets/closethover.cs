using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closethover : MonoBehaviour
{
    public GameObject closet;
    // Start is called before the first frame update
    void Start()
    {
        closet.SetActive(false);
    }
public void OnMouseOver()
    {

        closet.SetActive(true);
    }

    public void OnMouseExit()
    { 
        closet.SetActive(false);
    }
}
