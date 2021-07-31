using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
	[SerializeField] AudioSource bgMusic;
	private void Start()
	{		
		bgMusic.Play();
	}
	private void Update()
	{
		bgMusic.volume = SoundManager.instance.Music;
	}
}
