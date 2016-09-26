using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

    public GameObject Button1;
    public GameObject Button2;

    public bool button1Active;
    public bool button2Active;
    public bool done;

	// Use this for initialization
	void Start () {


        button1Active = true;
        button2Active = false;
        Button2.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        

    }

    public void buttonSwap()
    {

        done = false;

        if(button1Active == true && done == false)
        {

            button2Active = true;
            button1Active = false;
            Debug.Log("Swap1");
            done = true;

            Button1.SetActive(false);
            Button2.SetActive(true);
        }
        
        if(button2Active == true && done == false)
        {

            button1Active = true;
            button2Active = false;
            Debug.Log("Swap2");
            done = true;

            Button1.SetActive(true);
            Button2.SetActive(false);
        }

    }
}
