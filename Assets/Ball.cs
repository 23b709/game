using UnityEngine;
using System.Collections;

public class Ball: MonoBehaviour {

void Update () {
   if (Input.GetButtonDown("Fire1")) {
      transform.GetComponent<Rigidbody>().AddForce(transform.forward * 40, ForceMode.VelocityChange);
   }
  }
}

