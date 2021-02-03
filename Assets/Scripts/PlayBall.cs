using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBall : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ballObj = collision.collider.gameObject;
        if (ballObj.name == "Ball")
        {
            ballObj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 500.0f, 0));
        }
        else
        {
            Debug.Log("Not a ball");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
