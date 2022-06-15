using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterGameManager : MonoBehaviour
{
    public GameObject characterList;
    public Identities[] characterIdentities;

    public AudioSource newComboNotif;
    public AudioSource comboNotif;

    public GameObject scrollArea;
    public GameObject uiArea;
    public GameObject endScreen;

    public Text discoveryScoreText;
    public Text discoveryScoreTotalText;
    private int discoveryScore;
    private int completeScore;
    private int starterCounter;



    private void Start()
    {
        characterIdentities = characterList.GetComponentsInChildren<Identities>();

        for (int i = 0; i < characterIdentities.Length; i++)
        {
            if(characterIdentities[i].strokeId != Identities.StrokeCount.Starter)
            {
                
                characterIdentities[i].gameObject.SetActive(false);
            }

            else
            {
                starterCounter++;
            }
        }

        completeScore = characterIdentities.Length - starterCounter;
        discoveryScoreTotalText.text = $"     / {completeScore}";
    }



    private void Update()
    {
        characterIdentities = characterList.GetComponentsInChildren<Identities>();
    }



    public void CountScore(int score)
    {
        discoveryScore += score;
        discoveryScoreText.text = discoveryScore.ToString();

        if (discoveryScore == completeScore)
        {
            scrollArea.SetActive(false);
            uiArea.SetActive(false);
            endScreen.SetActive(true);
            ClearCanvas();
        }
    }



    public void ClearCanvas() {
    
        for (int i = 0; i < characterIdentities.Length; i++)
        {
            if (characterIdentities[i].positionStatus == Identities.Position.Canvas)
            {
                Destroy(characterIdentities[i].gameObject);
            }
        }
    }
}
