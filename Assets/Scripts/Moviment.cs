using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Moviment : MonoBehaviour
{
    private int playState = 0;
    public PathCreator pathCreator;
    public float speed = 5;
    [SerializeField]
    float distanceTravelled;

    void Update() {
        if (playState == 1) {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, EndOfPathInstruction.Stop);
        }
    }

    public void PlayButton() 
    {
        distanceTravelled = 0;
        playState = 1;
    }

}
