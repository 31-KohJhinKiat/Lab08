using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      if(transform.position.y <= -7 || transform.position.y >= 7)
        {
            SceneManager.LoadScene("LoseScene");
        }

    }

    public void OnCollisionEnter(Collision others)
    {
        if (others.gameObject.tag.Equals("Obstacle"))
        {
            print("Collide");
            SceneManager.LoadScene("LoseScene");
        }
    }
}
