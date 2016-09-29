using UnityEngine;
using System.Collections;

public class Move_Enemies : MonoBehaviour {

    public Vector2 aPosition1;

    public float Rand;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    // Use this for initialization
    void Start () {

        Rand = Random.Range(1, 3);

        if (Rand == 1)
        {

            aPosition1 = target1.transform.position;


        }

        if (Rand == 2)
        {

            aPosition1 = target2.transform.position;



        }

        if (Rand == 3)
        {

            aPosition1 = target3.transform.position;



        }

    }
	
	// Update is called once per frame
	void Update () {
	
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), aPosition1, 100 * Time.deltaTime);

	}

    void OnTriggerEnter2D(Collider2D other)
   {

        if (other.tag == "bullets")
        {

            Debug.Log("Hit");
            Destroy(this.gameObject);




        }

        if (other.tag == "target")
        {


            Destroy(this.gameObject);




        }




    }
}
