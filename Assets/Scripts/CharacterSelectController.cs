using UnityEngine;

public class CharacterSelectController : MonoBehaviour
{
	[SerializeField]
	private string character;

	private AudioSource audioSource;

	private void Start()
	{
		audioSource = SoundManager.instance.SFXButtonEffect;
	}

	public void MovetoTitleScreen()
	{		
		GameManager.instance.MoveToTitleScreen();		
		audioSource.Play();
	}
	
	public void SelectAlfredo()
	{
		GameManager.instance.characterSelect = "Alfredo";
		GameManager.instance.MoveToLoadingScreen();
	}

	public void SelectLily()
	{
		GameManager.instance.characterSelect = "Lily";
		GameManager.instance.MoveToLoadingScreen();
	}

	public void SelectPaco()
	{
		GameManager.instance.characterSelect = "Paco";
		GameManager.instance.MoveToLoadingScreen();
	}
	
	public void SelectCharacter()
	{		
		GameManager.instance.characterSelect = character;
		GameManager.instance.MoveToLoadingScreen();
		audioSource.Play();
	}
}
