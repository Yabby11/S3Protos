using UnityEngine;
using System.Collections;

public class scoringCircle : MonoBehaviour {

    public float scoreCircle;


	// Use this for initialization
	void Start () {

        this.GetComponent<BoxCollider2D>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {

        this.GetComponent<BoxCollider2D>().enabled = false;

    }

    public void OnPress()
    {

        this.GetComponent<BoxCollider2D>().enabled = true;


    }

    void OnTriggerEnter(Collider2D other)
    {

        if(other.tag == "circle" )
        {

            scoreCircle = scoreCircle + 100;


        }


    }
}
