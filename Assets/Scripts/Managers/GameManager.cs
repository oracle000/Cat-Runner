using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public int posY = -5;
    public int posX = -5;
    public float backgroundImageX = 0;
    public float backgroundImageY = 0;

    public void MoveToCharacterScene()
	{
        SceneManager.LoadScene(1);
	}

	public void MoveToTitleScreen()
	{
        SceneManager.LoadScene(0);
	}

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
