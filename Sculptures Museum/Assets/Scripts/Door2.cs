using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
	private Animator _animator;

	// Start is called before the first frame update
	void Start()
	{
		_animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && UserData.totalPoints >= 70)
		{
			_animator.SetBool("open", true);	
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
