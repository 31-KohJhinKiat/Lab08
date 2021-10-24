using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRollScript : MonoBehaviour
{

    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 700)
        {
            transform.position = new Vector3 (Screen.width/2, -300, 0);
        }


        transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
    }
}
