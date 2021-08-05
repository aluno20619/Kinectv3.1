using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
	
	 public bool ikActive = false;
	
	[Tooltip("O transform que precisa de ser segido pela mão do avatar")]
	public Transform handle;
	
	[Tooltip("O transform da mão direita do avatar")]
	public Transform rightHandObj;
	
    // Start is called before the first frame update
    void Start()
    {
		
         // myVector = new Vector3(0,0,0);
		 // handle.transform.parent = rightHandObj.gameObject.transform;
		// handle.transform.localPosition = myVector;
		//handle.transform.localRotation = Quaternion.identity;//rotação do objeto rightHandObj
    }

    // Update is called once per frame
    void Update()
    {
		// move o corpo e a mão para o target
		MoveHandToTarget();
      // handle.transform.parent = rightHandObj.gameObject.transform;
		// handle.transform.localPosition = myVector;
		//handle.transform.localRotation = Quaternion.identity;
	
		
}
private void MoveHandToTarget()
	{
		// if(rightHandObj == null)
		// {
			// Animator animatorComponent = GetComponent<Animator>();
			// rightHandObj = animatorComponent ? animatorComponent.GetBoneTransform(HumanBodyBones.RightHand) : null;
		// }
		Animator animator = GetComponent<Animator>();
	 if(animator) {
				
		//if the IK is active, set the position and rotation directly to the goal. 
		if(ikActive) {
			 if(rightHandObj != null) {
				animator.SetIKPositionWeight(AvatarIKGoal.RightHand,1);
				animator.SetIKRotationWeight(AvatarIKGoal.RightHand,1);  
				animator.SetIKPosition(AvatarIKGoal.RightHand,rightHandObj.position);
				animator.SetIKRotation(AvatarIKGoal.RightHand,rightHandObj.rotation);
			}     
		}
	 }
			 else {          
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand,0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand,0); 
                animator.SetLookAtWeight(0);
            }
		

		
}
}
