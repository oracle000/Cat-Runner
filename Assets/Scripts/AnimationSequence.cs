using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class AnimationSequence : MonoBehaviour
{
    [SerializeField]
    private int _FrameRate = 30;

    [SerializeField]
    private bool _Loop = false;

    [SerializeField]
    private float _Speed;

    [SerializeField]
    private string _Location;


    private Image mImage = null;
    private Sprite[] mSprites = null;
    private float mTimePerFrame = 0f;
    private float mElapseTime = 0f;
    private int mCurrentFrame = 0;


    void Start()
    {

        mImage = GetComponent<Image>();        
        LoadSpriteSheet();        
    }

    private void LoadSpriteSheet()
	{
        mSprites = Resources.LoadAll<Sprite>(_Location);
        if (mSprites != null && mSprites.Length > 0)
		{
            mTimePerFrame = 1f / _FrameRate;
            Play();
		}

	}

	public void Play()
	{
        enabled = true;
	}

	void Update()
    {
        mElapseTime += Time.deltaTime * _Speed;
        if (mElapseTime >= mTimePerFrame)
		{
            mElapseTime = 0;
            ++mCurrentFrame;
            SetSprite();
            if (mCurrentFrame >= mSprites.Length)
            {
                if (_Loop)
                    mCurrentFrame = 0;
                else 
                    enabled = false;
			}

		}        
    }

    private void SetSprite()
	{
        if (mCurrentFrame >= 0 && mCurrentFrame < mSprites.Length)                        
            mImage.sprite = mSprites[mCurrentFrame];
	}
}
