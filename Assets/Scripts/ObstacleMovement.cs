using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public Transform obstacleLoc;

    public Vector3 obstacleMovement = new Vector3(-.2f, 0f, 0f);

    // Update is called once per frame
    void Update() {
        obstacleLoc.position += obstacleMovement;

    }

}
