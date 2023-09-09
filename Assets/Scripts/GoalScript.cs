using DefaultNamespace;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
	public PlayerCheck playerCheck;
	public bool isSolved = false;
	public GameObject text;
	
	void OnTriggerEnter (Collider collider)
	{
		GameObject collidedWith = collider.gameObject;
		
		if (collidedWith.tag == gameObject.tag)
		{
			isSolved = true;

			GetComponent<Light>().enabled = false;
			
			text.SetActive(false);
			Destroy (collidedWith);
		}
	}
}