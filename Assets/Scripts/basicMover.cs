using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicSpin : MonoBehaviour
{
	public float spinSpeed=180.0f;
  public float movementSpeed=0.1f;
  public bool spin=true;
  public bool move=true;


    // Update is called once per frame
    void Update()
    {
      if(spin)
		gameObject.transform.Rotate(Vector3.up*spinSpeed*Time.deltaTime);
    if(move)
    gameObject.transform.Translate(Vector3.up* Mathf.Cos(Time.timeSinceLevelLoad)*movementSpeed);
    }
}
