using UnityEngine;

public class CharacterSelectController : MonoBehaviour
{
	[SerializeField]
	private string character;

   public void MovetoTitleScreen()
	{
		GameManager.instance.MoveToTitleScreen();
	}
	
	public void SelectCharacter()
	{
		GameManager.instance.characterSelect = 1;
	}
}
