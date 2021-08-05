using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMov : MonoBehaviour
{
	public GameObject Oculus;
	public float y, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		
        transform.position = new Vector3(Oculus.transform.position.x,Oculus.transform.position.y + y,Oculus.transform.position.z + z);
		
    }
}
