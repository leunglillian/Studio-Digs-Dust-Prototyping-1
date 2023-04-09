using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // speed of objects movement
    public float speed = 18f;

    private Rigidbody rig;


    // Start is called before the first frame update
    void Start()
    {
        // the main body of object
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // our axis, edit >> project setting >> input >> set key strokes to on so that keystrokes will automatically be read and fed into player movement
        float horAxis = Input.GetAxis("Horizontal");
        float verAxis = Input.GetAxis("Vertical");

        // calculate amount to move
        Vector3 movement = new Vector3(horAxis, 0, verAxis) * speed * Time.deltaTime;

        // move our object ody
        rig.MovePosition(transform.position + movement);
    }
}
