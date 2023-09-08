using UnityEngine;

public class GoalScript : MonoBehaviour
{
	// Флаг достижения цели
	public bool isSolved = false;

	// Метод сравнивает тег цели с тегами контактирующих с ним объектов
	void OnTriggerEnter (Collider collider)
	{
		GameObject collidedWith = collider.gameObject;

		// Если тег цели совпадет с тегом, контактирующего с ней объекта, 
		// то объект будет уничтожен, цель выполнена, а источник света в этом углу отключится
		if (collidedWith.tag == gameObject.tag)
		{
			// Цель достигнута
			isSolved = true;

			// Отключение источника света на объекте-цели
			GetComponent<Light>().enabled = false;

			// Уничтожение цветного шара
			Destroy (collidedWith);
		}
	}
}