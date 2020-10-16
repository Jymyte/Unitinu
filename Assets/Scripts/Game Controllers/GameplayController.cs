using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private Button restartGameButton;
    [SerializeField]
    private Text scoreText, pauseText;

    private int score;
}
