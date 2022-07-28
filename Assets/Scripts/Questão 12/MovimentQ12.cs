using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class MovimentQ12 : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    public float speedMult;
    public float X;
    float distanceTravelled;

    // Update is called once per frame
    void Update()
    {
        
        if (X > transform.position.x) {
            speed += Time.deltaTime;
            distanceTravelled += speed * Time.deltaTime;

        }
        else {
            speed += Time.deltaTime * speedMult;
            distanceTravelled += speed * Time.deltaTime;
        }
        
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, EndOfPathInstruction.Stop);
    }

}
