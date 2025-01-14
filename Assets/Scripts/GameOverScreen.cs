﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
    {
        public Text scoreText;
        public GameObject mainMenuScreen;
        public void Setup(int score)
        {
            gameObject.SetActive(true);
            scoreText.text = score + " POINTS";
        }

        public void RestartButton()
        {
            SceneManager.LoadScene("MinGame");
            PlayerController.lives = 3;
            PlayerController.score = 0;
            PlayerController.canMove = true;
        }
        public void MainMenuButton()
        {
            RestartButton();
            gameObject.SetActive(false);
            mainMenuScreen.SetActive(true);
        }
    }