using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{

    public void replay() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void menu() {
        SceneManager.LoadScene(0);
    }
}
