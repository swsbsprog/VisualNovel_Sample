using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable, Inspectable]
public class TurnInfo
{
    [Inspectable]
    public string name;
    [Inspectable]
    public string talk;
    [Inspectable]
    public Sprite image;

    public string notInspectable;
}
