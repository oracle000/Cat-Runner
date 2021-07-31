using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;    


    public void MoveToCharacterScene()
	{
        SceneManager.LoadScene(1);
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
