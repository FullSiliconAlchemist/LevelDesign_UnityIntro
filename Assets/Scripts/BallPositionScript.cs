using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPositionScript : MonoBehaviour
{
    private BallScript script;
    private Vector2 coord;
    public Transform b_Transform;
    public Transform target_Transform;
    private GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        this.floor = GameObject.Find("Floor/Surface");
    }

    // Update is called once per frame
    void Update()
    {

        float distance_To_Floor = (b_Transform.position.y - this.floor.GetComponent<Transform>().position.y) * 0.1f;

        this.target_Transform.localScale = new Vector3(distance_To_Floor, 0.3f, distance_To_Floor);

        this.gameObject.GetComponent<Transform>().position = new Vector3(b_Transform.position.x, -6.9f, b_Transform.position.z);
    }
}
