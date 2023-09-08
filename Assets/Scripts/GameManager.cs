using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Ссылка на каждый из четырех объектов-целей
	public GoalScript blue, green, red, orange;

	// Флаг окончания игры
	private bool isGameOver = true;

	// В каждом кадре менеджер проверяет, все ли цели выполнены. 
	// Если да, менеджер присваивает переменной isGameOver 
	// значение true и выводит на экран сообщение "Игра окончена"

	void Update ()
	{
		// Если все четыре цели будут достигнуты, то игра окончена
		isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;		
	}

	// Графический интерфейс, формируемый программным способом
	void OnGUI()
	{
		if(isGameOver) {
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "Игра окончена");

			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
			GUI.Label (rect2, "Хорошая работа!");
		}
	}
}