using UnityEngine;
using System.Collections;


public class CourseMove : MonoBehaviour {

    public GameObject course;

    public GameObject player;

    public float SpeedChange = 3;

    public float speed = 4;

    public bool SloMo;

    public bool cycle;

	// Use this for initialization
	void Start () {
	
        

	}
	
	// Update is called once per frame
	void Update () {

        course.transform.position += Vector3.down * Time.fixedDeltaTime * speed;

        if (GameObject.Find("Circle").GetComponent<PlayerController>().SloMo)
        {

            if (cycle == false)
            {
                speed = speed / SpeedChange;
                cycle = true;
            }

        }

        else
        {

            speed = 4;
            cycle = false;
        }

    }
}
