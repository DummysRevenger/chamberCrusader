using UnityEngine;
using UnityEngine.UI;

public class gunClicked : MonoBehaviour
{
    private Camera mainCamera;
    private Image buttonImage;

    private float animationDuration = 0.5f;

    public Sprite anim1;
    public Sprite anim2;
    public Sprite anim3;
    public Sprite anim4;
    public Sprite anim5;
    public Sprite anim6;
    public Sprite anim7;
    public Sprite anim8;
    public Sprite anim9;

    private bool playAnim;

    private bool startTimeSet = false;

    private float startTime = 0f;

    public Text theText;


    private void Start()
    {
        mainCamera = Camera.main;
        buttonImage = GetComponent<Image>();

        anim1 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_0");
        anim2 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_1");
        anim3 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_2");
        anim4 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_3");
        anim5 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_4");
        anim6 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_5");
        anim7 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_6");
        anim8 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_7");
        anim9 = Resources.Load<Sprite>("Scenes/gun anims/pistol anim big_8");

        
    }


    public void playAnimation()
    {


        playAnim = true;
    }

    private void Update()
    {
        

        

        

        if (playAnim == true)
        {
            if (!startTimeSet)
            {
                startTime = Time.time;
                startTimeSet = true;
            }

            float timeElapsed = (Time.time - startTime);

            


            if (timeElapsed < 0.0555f)
            {
                AudioSource audioSource = GetComponent<AudioSource>();

                audioSource.Play();
                buttonImage.sprite = anim1;
            }
            else if (timeElapsed < 0.1111f)
            {
                buttonImage.sprite = anim2;
            }
            else if (timeElapsed < 0.16666f)
            {
                buttonImage.sprite = anim3;
            }
            else if (timeElapsed < 0.2222f)
            {
                buttonImage.sprite = anim4;
            }
            else if (timeElapsed < 0.27777f)
            {
                buttonImage.sprite = anim5;
            }
            else if (timeElapsed < 0.33333f)
            {
                buttonImage.sprite = anim6;
            }
            else if (timeElapsed < 0.38888f)
            {
                buttonImage.sprite = anim7;
            }
            else if (timeElapsed < 0.44444f)
            {
                buttonImage.sprite = anim8;
            }
            else
            {
                buttonImage.sprite = anim9;
                playAnim = false;
                startTimeSet = false;


            }

            
        }

        

        
         
        


    }
}