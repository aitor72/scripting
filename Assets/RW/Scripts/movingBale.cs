using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBale : MonoBehaviour
{
	public Vector3 movementSpeed = new Vector3(0,0,20);
	public Space space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed* Time.deltaTime, space);

    }
}
