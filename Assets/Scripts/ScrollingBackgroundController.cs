using UnityEngine;

public class ScrollingBackgroundController : MonoBehaviour
{
	
	[SerializeField]
	private GameObject BackgroundImage;
	private int posY;
	private int posX;

	private void Start()
	{
		posY = -5;
		posX = 5;
	}


	private void Update()
	{		
		if (BackgroundImage.transform.position.y < -4)		
			posY = 5;
		 else if (BackgroundImage.transform.position.y > 4)		
			posY = -5;
		
		if (BackgroundImage.transform.position.x > 15)		
			posX = 5;
		 else if (BackgroundImage.transform.position.x < -15)		
			posX = -5;
		
		
		BackgroundImage.transform.position = new Vector3(
			BackgroundImage.transform.position.x - posX * Time.deltaTime,
			BackgroundImage.transform.position.y + posY * Time.deltaTime, 
			BackgroundImage.transform.position.z);
				
	}
	
}
