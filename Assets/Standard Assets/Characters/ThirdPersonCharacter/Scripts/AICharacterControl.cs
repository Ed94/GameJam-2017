using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]

    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for

		BoxCollider field;

		bool banana = false;


        private void Start()
        {


            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;

			field = GetComponent<BoxCollider>();
        }


        private void Update()
        {
			if(banana == true) 
			{
				if (target != null)
					agent.SetDestination (target.position);
				
				character.Move (agent.desiredVelocity, false, false);
			}
		}

					
           // if (agent.remainingDistance > agent.stoppingDistance)
			//{
			//	OnTriggerEnter()
			//}
            //else
              //  character.Move(Vector3.zero, false, false);*/
		void OnTriggerEnter(Collider other)
		{
			if (other.Equals (Camera.main.GetComponent<BoxCollider> ())) 
			{
				banana = true;
			}


		}
		
        public void SetTarget(Transform target)
        {
            this.target = target;
        }

        void OnCollisionEnter (CapsuleCollider other) 
        {
			if (other.Equals (Camera.main.GetComponent<CapsuleCollider> ())) 
			{
				SceneManager.LoadScene("gameover");
			}
        }
    }
}
