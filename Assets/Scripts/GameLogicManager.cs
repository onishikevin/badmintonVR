using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogicManager : MonoBehaviour
{
    public static GameLogicManager Instance;

    [SerializeField]
    private GameObject _canvas;

    private TextMeshProUGUI _scoreText;

    private int _score = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            Instance. _score = 0;
            Instance._scoreText = _canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            Instance._scoreText.text = _score.ToString();
        }
    }



    public void AddScore(int score)
    {
        Instance._score += score;
        Instance._scoreText.text = _score.ToString();
    }
}
