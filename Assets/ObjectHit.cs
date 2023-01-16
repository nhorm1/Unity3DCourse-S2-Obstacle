using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
  {
    Debug.Log("Bump into the wall");
    GetComponent<MeshRenderer>().material.color = Color.magenta;
  }
}