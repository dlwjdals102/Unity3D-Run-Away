using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] TMP_Text timeText;
    [SerializeField] GameObject gameOverText;
    [SerializeField] float startTime = 30f;

    float playTime;
    public bool GameOver {  get; private set; }

    void Start()
    {
        playTime = startTime;
    }

    void Update()
    {
        DecreaseTime();
    }

    public void IncreaseTime(float amount)
    {
        playTime += amount;
    }

    void DecreaseTime()
    {
        if (GameOver) return;

        playTime -= Time.deltaTime;
        timeText.text = playTime.ToString("F1");

        if (playTime <= 0f)
        {
            PlayerGameOver();
        }
    }

    void PlayerGameOver()
    {
        GameOver = true;
        playerController.enabled = false;
        gameOverText.SetActive(true);
        Time.timeScale = .1f;
    }
}
