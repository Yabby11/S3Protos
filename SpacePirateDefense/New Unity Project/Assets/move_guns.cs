using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class move_guns : MonoBehaviour {

    public GameObject Slider2;
    public float Slider2VAL;


	// Use this for initialization
	void Start () {

        Slider2VAL = Slider2.gameObject.GetComponent<Slider>().value;

	}
	
	// Update is called once per frame
	void Update () {

        Slider2VAL = this.GetComponent<Slider>().value;
        Slider2.gameObject.GetComponent<Slider>().value = Slider2VAL;



    }
}
