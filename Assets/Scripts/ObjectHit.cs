using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  [SerializeField] float resetHitTime = 3f;
  float lastHitTime = 0f;
  Color origColor;

  private void Start()
  {
    origColor = GetComponent<MeshRenderer>().material.color;
  }

  private void Update()
  {
    if( resetHitTime > 0 && 
        lastHitTime > 0 &&
        ( Time.time > (lastHitTime + resetHitTime) ) )
    {
      GetComponent<MeshRenderer>().material.color = origColor;
      gameObject.tag = "Untagged";
    }
  }

  private void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.tag == "Player")
    {
      if (gameObject.tag != "Hit")
      {
        lastHitTime = Time.time;
      }

      GetComponent<MeshRenderer>().material.color = Color.magenta;
      gameObject.tag = "Hit";
    }
  }
}
