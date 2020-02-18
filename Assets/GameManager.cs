using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int theScore = -1;

    public int numObstacles = 4;
    public int whichObstacle = 0;

    // obstacle prefab
    public GameObject obstaclePrefab;

    private float nextActionTime = 0.0f;
    public float period = 1.7f;

    public AudioSource coolMusic;


    void Start() {
        nextActionTime = Time.time;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach(GameObject enemy in enemies)
        GameObject.Destroy(enemy);
        coolMusic.Play();
    }

    void Update () {
        if (Time.time > nextActionTime ) {
            nextActionTime += period;

            spawnObstacles();
            Invoke("incrementScore", 1f);
        }
    }

    void incrementScore() {
        theScore++;
    }

    public void spawnObstacles() {
        float center = Random.Range(-8f, 13.0f);
        // float center = Random.Range(-3f, 3.0f);

        
        // spawn obstacle above, will delete it after spawns
        GameObject topObstacle = (GameObject) Instantiate(obstaclePrefab, new Vector3(16f, 35f + center, 0), Quaternion.identity);
        Destroy(topObstacle, 5f);

        // spawn below, deletes after
        GameObject botObstacle = (GameObject) Instantiate(obstaclePrefab, new Vector3(16f, -35f + center, 0), Quaternion.identity);
        Destroy(botObstacle, 5f);
    }

    public void hitObstacle() {
        // compare current score to high score
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (theScore >= highScore) {
            PlayerPrefs.SetInt("HighScore", theScore);
        }
        
        // load game over scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
