using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadScore : MonoBehaviour {

    public Text score;
    public AudioSource dieSound;

    // Start is called before the first frame update
    void Start() {
        dieSound.Play();
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        score.text = highScore.ToString();
    }

}
