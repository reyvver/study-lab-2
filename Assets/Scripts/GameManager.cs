using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
	public UIManager ui;
	public FirstPersonController player;
	// Ссылка на каждый из четырех объектов-целей
	public GoalScript blue, green, red, orange, purple;

	// Флаг окончания игры
	public bool isGameOver = true;

	private bool gameFinishCheck;
	private float elapsedTime = 0;

	// В каждом кадре менеджер проверяет, все ли цели выполнены. 
	// Если да, менеджер присваивает переменной isGameOver 
	// значение true и выводит на экран сообщение "Игра окончена"

	private void Awake()
	{
		elapsedTime = 0;
	}

	void Update ()
	{
		// Если все четыре цели будут достигнуты, то игра окончена
		isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && purple.isSolved;	
		
		if (!isGameOver)
		{
			elapsedTime += Time.deltaTime;
			ui.UpdateTimeText((int)elapsedTime);
		}
		
		if(isGameOver && !gameFinishCheck)
		{
			Cursor.visible = true;
			gameFinishCheck = true;
			player.StopMovement();
			ui.ShowFinishPanel();
		}
		
		if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

	}

	public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}