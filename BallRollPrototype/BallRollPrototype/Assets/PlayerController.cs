using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public GameObject player;

    public float speed = 10f;
    private Vector2 target;
    public GameObject targetGO;
    public float SpeedSloMoFactor = 3;
    public bool SloMo;
    public float Pickups;


    void Awake()
    {
   
    }

    void Start()
    {
        target = transform.position;
        
        


    }


    // Update is called once per frame
    void Update()
    {

        

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.y = transform.position.y;

        

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        SloMo = false;


        if (player.transform.position == targetGO.transform.position)
        {

            SloMo = true;

        }
           

  

       





    

   
}


    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Pickups: " + Pickups);
    }




    void OnTriggerEnter2D(Collider2D Other)
    {

        if (Other.tag == "Obstacle")
        {

            SceneManager.LoadScene(0);
        }


        if (Other.tag == "Pickup")
        {

            Pickups += 1;

        }

        if (Other.tag == "Obstacle")
        {

            if(Pickups >= 5)
            {

                SceneManager.LoadScene(0);

            }

        }

    }
}
