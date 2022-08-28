using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TurnManager : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text talkText;
    [SerializeField] Image characterImage;
    [SerializeField] CanvasGroup canvasGroup;

    public List<TurnInfo> turnInfos = new();
    public int index;

    private void Start()
    {
        canvasGroup.DOFade(1, 0.5f);
        DoNext();
    }
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

    public float speechSpeed = 0.3f;
    private void UpdateUI(TurnInfo turnInfo)
    {
        nameText.text = turnInfo.name;
        characterImage.sprite = turnInfo.image;

        talkText.text = "";
        talkText.DOText(turnInfo.talk, speechSpeed);
    }
}
