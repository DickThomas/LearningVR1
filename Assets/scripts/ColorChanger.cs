using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
  public void setColorRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        
    }

  public void setColourBlue()
    {

        GetComponent<MeshRenderer>().material.color = Color.green;


    }
}

