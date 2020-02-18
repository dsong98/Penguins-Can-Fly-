using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text ScoreText;

    public GameManager gameManager;

    void Update() {
        if (gameManager.theScore == -1) {
            ScoreText.text = "0";
        }
        else {
            ScoreText.text = gameManager.theScore.ToString();
        }
        
    }
}
