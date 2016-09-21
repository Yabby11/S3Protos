using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public GameObject player;

    public float speed = 1.5f;
    private Vector2 target;

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


        //for touch
        /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
         {
             Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

             //Check if it is left or right?
             if (touchDeltaPosition.x < 0.0f)
             {
                 player.transform.Translate(Vector3.left * 10 * Time.deltaTime);
             }
             else if (touchDeltaPosition.x > 0.0f)
             {
                 player.transform.Translate(Vector3.right * 10 * Time.deltaTime);
             }

         }
         */
    }
}
