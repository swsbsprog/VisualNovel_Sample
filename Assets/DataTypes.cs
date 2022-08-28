using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[Inspectable]
[System.Serializable]
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
