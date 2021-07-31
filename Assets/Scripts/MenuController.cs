using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

	[SerializeField] private Slider MusicSlider;
	[SerializeField] private Slider SFXSlider;

	private AudioSource ad;

	private void Start()
	{		
		ad = GetComponent<AudioSource>();		
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
		ad.volume = SoundManager.instance.SFX;
		ad.Play();		
	}
}
