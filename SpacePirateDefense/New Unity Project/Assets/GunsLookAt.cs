using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GunsLookAt : MonoBehaviour {

    public Transform target;
   


	// Use this for initialization
	void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {


        Vector3 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);


    }
}
