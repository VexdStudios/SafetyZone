using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateMenu : MonoBehaviour
{
  public float spinSpeed; //assign in inspector for speed

  void Update()
  {
    transform.Rotate (0,spinSpeed,0);
  }
}
