using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    const float hozBoundry = 10.0f;
    const float verBoundry = 10.0f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    
    void Start()
    {
        int num1 = 3;
        float result = 1 / num1;
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        //Dont't let player move of the grass to the right
        if (transform.position.x > hozBoundry)
        {
            transform.position = new Vector3(hozBoundry, transform.position.y, transform.position.z);
        }
        //Don't let the player move of the grass to the left
        if (transform.position.x < -hozBoundry)
        {
            transform.position = new Vector3(-hozBoundry, transform.position.y, transform.position.z);
        }

        float hozInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * hozInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }


    }
}
