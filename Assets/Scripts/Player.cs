using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;

    // location of player
    public Transform playerLoc;

    // force to jump with
    public Vector2 jumpForce = new Vector2(0f, 3500f);

    // jump sound and background music
    public AudioSource jumpSound;

    void Start() {
        Vector3 pos = new Vector3(-12f, 2f, 0f);
        playerLoc.position = pos;
    }
    // Update is called once per frame
    void Update() {
        // check for jump
        if (Input.GetMouseButtonDown(0) | (Input.GetKeyDown("space"))) {
            // Touch touch = Input.GetTouch(0);
            // Debug.Log(jumpForce.y);
            jumpSound.Play();
            rb.AddForce(jumpForce, ForceMode2D.Force);

        }
    }

    // detect collision
        void OnCollisionEnter2D(Collision2D col) {
            if (col.collider.tag == "Obstacle") {
                FindObjectOfType<GameManager>().hitObstacle();
            }
        }
}
