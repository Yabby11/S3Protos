using UnityEngine;
using System.Collections;

public class ScrollDown : MonoBehaviour {

    public GameObject course;
    public float speed = 5;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        course.transform.position += Vector3.down * Time.fixedDeltaTime * speed;

    }
}
