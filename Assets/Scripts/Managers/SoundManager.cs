using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public static SoundManager instance;
	public float Music = 1;
	public float SFX = 1;	

	private void Awake()
	{
		MakeSingleton();
	}

	private void MakeSingleton()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
}
