using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.collider.gameObject;
        if (obj.name == "Surface")
        {
            player.GetComponent<PlayBall>().ResetScore();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("MyCharacter");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector2 GetBallCoordinates()
    {
        //return new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.z);
        return new Vector2(this.gameObject.GetComponent<Transform>().position.x, this.gameObject.GetComponent<Transform>().position.z);
    }

}
