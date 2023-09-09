using System;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{
	private Rigidbody _rigidbody;
	// Определение начальной скорости для перемещения шара хаоса
	public float startSpeed = 50f;
	public float clampVelocity = 100;

	void Start ()
	{
		// Получаем доступ к компоненту Rigidbody
		_rigidbody = GetComponent<Rigidbody> ();
		//Задаем вектор скорости шара хаоса
		_rigidbody.velocity = new Vector3 (startSpeed, 0, startSpeed);
	}

	private void FixedUpdate()
	{
		if (_rigidbody == null) return;
		
		var v = _rigidbody.velocity;
		
		if (_rigidbody.velocity.magnitude > clampVelocity) 
			_rigidbody.velocity = v.normalized * clampVelocity;
		
		Debug.Log(_rigidbody.velocity);

	}
}
