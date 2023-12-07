using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TMP_Text lapCounterText, bestLapTimeText, currentLapTimeText, positionText, countDownText, goText, raceResultText;

    public GameObject resultsScreen;
    private void Awake()
    {
        instance = this;
    }

}
