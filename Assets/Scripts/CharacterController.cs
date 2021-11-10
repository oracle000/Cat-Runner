using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] ListofChar;
	
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    

    void Start()
    {        
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        LoadSprite();        
	}

    
    void Update()
    {        
    }

    void LoadSprite()
	{		
		switch (GameManager.instance.characterSelect)
		{
			case "Alfredo":
				spriteRenderer.sprite = ListofChar[0];
				animator.SetInteger("Character", 0);
				break;

			case "Lily":
				spriteRenderer.sprite = ListofChar[1];
				animator.SetInteger("Character", 1);
				break;

			case "Paco":
				spriteRenderer.sprite = ListofChar[2];
				animator.SetInteger("Character", 2);
				break;
		}
	}    
}
