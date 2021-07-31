using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;    

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
