using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public Text nameText;
    public Text talkText;
    public Image characterImage;

    public List<TurnInfo> turnInfos = new();
    public int index;

    private void Start() => DoNext();
    void Update()
    {
        if (Input.anyKeyDown)
            DoNext();
    }
    private void DoNext()
    {
        UpdateUI(turnInfos[index]);
        index++;    
    }

    private void UpdateUI(TurnInfo turnInfo)
    {
        nameText.text = turnInfo.name;
        talkText.text = turnInfo.talk;
        characterImage.sprite = turnInfo.image;
    }
}
