using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
	protected Vector3 inic;
    // Start is called before the first frame update
    void Start()
    {
        inic = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnCollisionEnter(Collision col) {
     if (col.collider.tag == "Terrain" ) {
        transform.position = inic;
		GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,0f);
		GetComponent<Rigidbody>().angularVelocity = new Vector3(0f,0f,0f);
     }
 }
    
}
