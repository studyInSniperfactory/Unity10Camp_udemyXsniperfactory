using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoseChanger : MonoBehaviour
{
	Animator anim;

    void Start()
    {
		anim = null;    
    }

	void Update()
	{
		if (Input.GetButtonDown("Jump"))
		{
			if (anim == null)
			{
				anim = GetComponent<Animator>();
			}
			else
			{
				anim.SetTrigger("Next");
			}
		}
	}
}
