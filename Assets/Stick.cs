using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{

    public string StuckObjectTag = "Target";



    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("other:"+other.gameObject.name);

        //if (other.gameObject.CompareTag(StuckObjectTag))

       // {
        //    GetComponent<Rigidbody>().isKinematic = true;
      //  }
    }



}

