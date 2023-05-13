using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class InGameCanvasBehaviour : MonoBehaviour {
    public Sprite redLight;
    public Sprite greenLight;
    public Sprite yellowLight;
    private Image lightImage;

    public static TextMeshProUGUI colorTMP;
    private static TextMeshProUGUI countdownText;

    public static Canvas gameResult;
    private static TextMeshProUGUI winnerText;
    private static TextMeshProUGUI loserText;

    private static Canvas answerCanvas;

    void Awake() {
        lightImage = GameObject.Find("TrafficLight").GetComponent<Image>();
        

        // Countdown
        colorTMP = GameObject.Find("Color").GetComponent<TextMeshProUGUI>();
        countdownText = GameObject.Find("CountdownText").GetComponent<TextMeshProUGUI>();

        // Answers for both players
        answerCanvas = GameObject.Find("AnswerCanvas").GetComponent<Canvas>();

        // GameResult
        gameResult = GameObject.Find("GameResult").GetComponent<Canvas>();
        winnerText = GameObject.Find("WinnerText").GetComponent<TextMeshProUGUI>();
        loserText = GameObject.Find("LoserText").GetComponent<TextMeshProUGUI>();

    }

    void Start() {
        InvokeRepeating("Countdown", 0f, 1.5f);
    }

    public static void UpdateColorTMP() {
        // Update the text of the TextMeshPro component
        colorTMP.text = RandomizeColor.randomizedColor;
        colorTMP.color = Color.white;
    }

    static int countdownCounter = 2;
    private void Countdown() {
        if (countdownCounter == 2) {
            lightImage.sprite = redLight;
            countdownCounter--;
            
        }
        else if (countdownCounter == 1) {
            lightImage.sprite = yellowLight;
            countdownCounter--;
        }
        else if (countdownCounter == 0) {
            countdownText.color = Color.green;
            lightImage.sprite = greenLight;
            countdownText.text = "Go!";
            GameBehaviour.gameStarted = true;
            countdownCounter--;
        } else {
            countdownText.text = "";
            Destroy(lightImage);
        }

    }


    
    public static void ShowWinner(string winner, string loser) {
        answerCanvas.enabled = false;
        winnerText.text = "1. " + winner;
        winnerText.color = new Color(1.0f, 0.843f, 0.0f);
        loserText.text = "2. " + loser;
        loserText.color = new Color(0.753f, 0.753f, 0.753f);
    }
    
}
