using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
  MeshRenderer dropperRenderer;
  Rigidbody dropperRigidbody;
  bool dropped = false;
  [SerializeField] float timeToWait = 3f;

  // Start is called before the first frame update
  void Start()
  {
    dropperRenderer = GetComponent<MeshRenderer>();
    dropperRigidbody = GetComponent<Rigidbody>();

    dropperRenderer.enabled = false;
    dropperRigidbody.useGravity = false;
  }

  // Update is called once per frame
  void Update()
  {
    if (!dropped && Time.time > timeToWait)
    {
      dropperRenderer.enabled = true;
      dropperRigidbody.useGravity = true;
      dropped = true;

      Debug.Log(timeToWait + " seconds has elapsed");
    }
  }
}
