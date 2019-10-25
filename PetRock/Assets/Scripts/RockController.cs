using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{


    public string rockname = "Rockee";
    public float hunger = 100f;
    public float friendship = 100f;
    public bool isSick = false;

    float hungerscale = 2f;
    float friendscale = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(rockname);
    }

    // Update is called once per frame
    void Update()
    {
        StatusUpdate();
        Debug.Log(hunger);
        Debug.Log(friendship);
        Debug.Log(isSick);
        IsDead();
    }

    void StatusUpdate()
    {
        hunger -= Time.deltaTime * hungerscale;
        friendship -= Time.deltaTime * friendscale;

        int sickChance = Random.Range(0, 400);
        if (sickChance == 1)
        {
            isSick = true;
        }

        if (isSick == false)
        {
            hungerscale = 2f;
            friendscale = 2f;
        }

        else
        {
            hungerscale = 5f;
            friendscale = 5f;
        }


    }

    void IsDead()
    {
        if (hunger <= 0)
        {
            //Destroy(gameObject);
        }
        else if (friendship <= 0)
        {
            Destroy(gameObject);
        }
    }
}