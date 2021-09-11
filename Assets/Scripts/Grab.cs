using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
	public GameObject Hand;
	public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    transform.position = new Vector3(Hand.transform.position.x + x,Hand.transform.position.y + y,Hand.transform.position.z + z);
		transform.rotation = Quaternion.Euler(Hand.transform.rotation.x, Hand.transform.rotation.y, Hand.transform.rotation.z);
    }
}


		
