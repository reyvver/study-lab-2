using UnityEngine;

public class VelocityScript : MonoBehaviour
{   
	// Определение начальной скорости для перемещения шара хаоса
	public float startSpeed = 50f;

	void Start ()
	{
		// Получаем доступ к компоненту Rigidbody
		Rigidbody rigidBody = GetComponent<Rigidbody> ();

		//Задаем вектор скорости шара хаоса
		rigidBody.velocity = new Vector3 (startSpeed, 0, startSpeed);
	}
}
