using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public int posY = -5;
    public int posX = -5;
    public float backgroundImageX = 0;
    public float backgroundImageY = 0;

    public string characterSelect = "";

    public void MoveToCharacterScene()
	{
        SceneManager.LoadScene(1);
	}

	public void MoveToTitleScreen()
	{
        SceneManager.LoadScene(0);
	}

    public void MoveToLoadingScreen()
	{
        SceneManager.LoadScene(2);        
	}

	public void MoveToLevel1()
	{        
        StartCoroutine(AddDelayLevel1());        
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


    public IEnumerator AddDelayLevel1()
	{
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
    

}
