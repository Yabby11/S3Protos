using UnityEngine;
using System.Collections;

public class GunShoot : MonoBehaviour
{

    public GameObject BulletPrefab;

    public RectTransform muzzle;

    public RectTransform bullets;

    public float timer = 3;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0)
        {

           GameObject tempBullet = Instantiate(BulletPrefab, bullets) as GameObject;
            tempBullet.transform.position = muzzle.transform.position;
            tempBullet.transform.rotation = muzzle.transform.rotation;
            timer = 3;

        }
    }




}
