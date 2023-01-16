using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scorer : MonoBehaviour
{
  int hits = 0;

  private void OnCollisionEnter(Collision collision)
  {
    if( collision.gameObject.tag != "Hit" )
    {
      hits++;
      Debug.Log("You've bumped into a thing this may times: " + hits);
    }
  }
}
