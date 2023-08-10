using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeSurfer
{
	[RequireComponent(typeof(Rigidbody))]
	public class ObstacleCube : MonoBehaviour
	{
		private bool _isActive = false;
		public bool isActive { get => _isActive; set => _isActive = value; }

		public GameObject _object;

		public void Spawn(float position,bool active)
		{
			_object.SetActive(active);
			transform.position = new Vector3(0f,0.5f,position);
		}
		public void SetActive(bool active)
		{
			_object.SetActive(active);
		}
	}

}
