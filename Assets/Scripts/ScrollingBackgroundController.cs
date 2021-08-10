using UnityEngine;

public class ScrollingBackgroundController : MonoBehaviour
{
	
	[SerializeField]
	private GameObject BackgroundImage;


	private void Start()
	{
		BackgroundImage.transform.position = new Vector3(
			GameManager.instance.backgroundImageX,
			GameManager.instance.backgroundImageY,
			BackgroundImage.transform.position.z);
		
	}

	private void Update()
	{
		if (BackgroundImage.transform.position.y < -4)
			GameManager.instance.posY = 5;
		else if (BackgroundImage.transform.position.y > 4)
			GameManager.instance.posY = -5;

		if (BackgroundImage.transform.position.x > 15)
			GameManager.instance.posX = 5;
		else if (BackgroundImage.transform.position.x < -15)
			GameManager.instance.posX = -5;


		BackgroundImage.transform.position = new Vector3(
			BackgroundImage.transform.position.x - GameManager.instance.posX * Time.deltaTime,
			BackgroundImage.transform.position.y + GameManager.instance.posY * Time.deltaTime, 
			BackgroundImage.transform.position.z);

		GameManager.instance.backgroundImageX = BackgroundImage.transform.position.x;
		GameManager.instance.backgroundImageY = BackgroundImage.transform.position.y;



	}
	
}
