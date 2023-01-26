using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKugel : MonoBehaviour
{
 
 private void OnCollisionEnter(Collision collision)
   {
		 Debug.Log("Collision");
   }
  
   private void OnTriggerEnter(Collider other)
   {
		  Debug.Log("Trigger");
		  Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
		  rb.velocity = Vector3.zero;
		  rb.isKinematic = true;
		  rb.useGravity = true;
   }
 }

