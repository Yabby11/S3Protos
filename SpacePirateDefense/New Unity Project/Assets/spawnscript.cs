using UnityEngine;
using System.Collections;

public class spawnscript : MonoBehaviour {

    public int Rand;

    public float timer = 4;

    public RectTransform spawn1;
    public RectTransform spawn2;
    public RectTransform spawn3;

    public GameObject enemy;


    // Use this for initialization
    void Start () {

        Rand = Random.Range(1, 3);

    }
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (Rand == 1 && timer <= 0)
        {

            GameObject tempBullet = Instantiate(enemy, spawn1.position, spawn1.rotation) as GameObject;
            tempBullet.transform.position = spawn1.transform.position;
            tempBullet.transform.rotation = spawn1.transform.rotation;
            tempBullet.transform.parent = spawn1;

            Rand = Random.Range(1, 3);

            timer = 4;

        }

        if (Rand == 2 && timer <= 0)
        {


            GameObject tempBullet = Instantiate(enemy, spawn2.position, spawn2.rotation) as GameObject;
            tempBullet.transform.position = spawn2.transform.position;
            tempBullet.transform.rotation = spawn2.transform.rotation;
            tempBullet.transform.parent = spawn2;


            Rand = Random.Range(1, 3);

            timer = 4;

        }

        if (Rand == 3 && timer <= 0)
        {


            GameObject tempBullet = Instantiate(enemy, spawn3.position, spawn3.rotation) as GameObject;
            tempBullet.transform.position = spawn3.transform.position;
            tempBullet.transform.rotation = spawn3.transform.rotation;

            tempBullet.transform.parent = spawn3;

            Rand = Random.Range(1, 3);

            timer = 4;

        }


    }
}
