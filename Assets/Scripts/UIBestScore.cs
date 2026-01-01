using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[DefaultExecutionOrder(1000)]
public class UIBestScore : MonoBehaviour
{
    public TMP_Text bestScoreText;

    void Start()
    {
        if (SaveManager.Instance != null) {
            bestScoreText.text = "Best Score : " + SaveManager.Instance.bestScore + " Name : " + SaveManager.Instance.playerName;
        }
    }
}
