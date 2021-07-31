using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	[SerializeField] private Slider MusicSlider;
	[SerializeField] private Slider SFXSlider;

	private AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();		
	}

	private void Update()
	{
		audioSource.volume = SoundManager.instance.SFX;
	}

	public void LoadCharacterScene()
	{
		GameManager.instance.MoveToCharacterScene();
		audioSource.Play();
	}

	public void OnUpdateMusicSlider(float value)
	{
		SoundManager.instance.Music = value;		
	}

	public void OnUpdateSFXSlider(float value)
	{
		SoundManager.instance.SFX = value;
	}

	public void OnClickSettings()
	{
		MusicSlider.value = SoundManager.instance.Music;
		SFXSlider.value = SoundManager.instance.SFX;
		audioSource.Play();		
	}

	public void OnClickBack()
	{
		audioSource.Play();
	}
}
