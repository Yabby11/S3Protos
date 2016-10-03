using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class scoring : MonoBehaviour {

    public GameObject scoreCircle;
    public GameObject scoreSquare;

    public float totalScore;

    public Text score;

    // Use this for initialization
    void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

        totalScore = scoreCircle.GetComponent<scoringCircle>().scoreCircle + scoreSquare.GetComponent<scoringSquare>().scoreSquare;

        score.text = "Score: " + score;

	}

   
}
