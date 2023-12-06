using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField]
    float playerSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horDirInput = Input.GetAxis("Horizontal");
        float verDirInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horDirInput, 0, verDirInput);
        movementDirection.Normalize();

        transform.position = transform.position + movementDirection * playerSpeed * Time.deltaTime;

       
    }
}
