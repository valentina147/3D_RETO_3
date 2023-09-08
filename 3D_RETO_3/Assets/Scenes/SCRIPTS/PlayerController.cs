using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int limite = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") && gameObject.transform.position.x < limite)
        {
            gameObject.transform.Translate(1.5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left") && gameObject.transform.position.x > -limite)
        {
            gameObject.transform.Translate(-1.5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown("space"))
        {
            gameObject.transform.Translate(0, 0.3f, 0);
        }
    }
}
