using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Moves the saw towards the player and destroys the Saw clones after a certain distance
        transform.position -= new Vector3(0.03f, 0,0);
        if(transform.position.x < -25.06017f)
        {
            Destroy(this.gameObject);
        }
    }
}
