using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBall : MonoBehaviour
{
    private bool firstTouch = false;
    public Text Score_UIText; // assign it from inspector
    private int score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ballObj = collision.collider.gameObject;
        if (ballObj.name == "Ball")
        {
            if (!firstTouch)
            {
                GameObject.Find("Canvas/Tutorial").SetActive(firstTouch);
                firstTouch = true;
            }
            ballObj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 500.0f, 0));
            score++;
        }
    }

    public void ResetScore()
    {
        this.score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        Score_UIText.text = "SCORE: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Score_UIText.text = "SCORE: " + score.ToString();
    }
}
