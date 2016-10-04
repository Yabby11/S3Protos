using UnityEngine;
using System.Collections;

public class scoringSquare : MonoBehaviour
{

    public float scoreSquare;


    // Use this for initialization
    void Start()
    {

        this.GetComponent<BoxCollider2D>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    public void OnPress()
    {

        this.GetComponent<BoxCollider2D>().enabled = true;


    }

    void OnTriggerEnter(Collider2D other)
    {

        if (other.tag == "box")
        {

            scoreSquare = scoreSquare + 100;


        }


    }
}