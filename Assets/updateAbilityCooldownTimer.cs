using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateAbilityCooldownTimer : MonoBehaviour
{


    public Text text;

    public GameObject knight;

    public GameObject shield;

    public activateShield activateShieldScript;

    public protectiveAbility protectiveScript;

    public slash slashScript;

    public ninjaDash dashScript;

    public GameObject slashAxis;

    public placeC4 C4PlacementScript;

    public rocketJump rocketJumpScript;

    public launchFireWork fireWorkScript;

    public rampageAbility rampageScript;

    private Component attackScript;

    private Component defenceScript;



    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();

        /*
        if (shield != null && knight != null)
        {
            activateShieldScript = shield.GetComponent<activateShield>();
            protectiveScript = knight.GetComponent<protectiveAbility>();
        }



        switch (playerSwitcher.S.playerType)
        {
            case "knight":

                attackScript = activateShieldScript;
                defenceScript = protectiveScript;
                break;

            case "soldier":
                if (gameObject.name == "AabilityCooldown")
                {
                    if (C4PlacementScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(C4PlacementScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "F";
                    }
                }
                else if (gameObject.name == "DabilityCooldown")
                {
                    if (rocketJumpScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(rocketJumpScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "E";
                    }
                }
                break;

            case "bunny":
                if (gameObject.name == "AabilityCooldown")
                {
                    if (C4PlacementScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(C4PlacementScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "F";
                    }
                }
                else if (gameObject.name == "DabilityCooldown")
                {
                    if (rocketJumpScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(rocketJumpScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "E";
                    }
                }
                break;

        }*/







    }

    // Update is called once per frame
    void Update()
    {

        switch (playerSwitcher.S.playerType)
        {
            case "knight":

                if (gameObject.name == "AabilityCooldown")
                {
                    if (activateShieldScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(activateShield.S.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                else if (gameObject.name == "DabilityCooldown")
                {
                    if (protectiveScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(protectiveScript.cooldownTimer * 10) / 10;



                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                break;

            case "ninja":

                if (gameObject.name == "AabilityCooldown")
                {
                    if (slashScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(slashScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                else if (gameObject.name == "DabilityCooldown")
                {
                    if (dashScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(dashScript.cooldownTimer * 10) / 10;



                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                break;

            case "soldier":
                if (gameObject.name == "AabilityCooldown")
                {
                    if (C4PlacementScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(C4PlacementScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
               else if (gameObject.name == "DabilityCooldown")
                {
                    if (rocketJumpScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(rocketJumpScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                break;

            case "bunny":
                if (gameObject.name == "AabilityCooldown")
                {
                    if (fireWorkScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(fireWorkScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                else if (gameObject.name == "DabilityCooldown")
                {
                    if (rampageScript.cooldownTimer > 0)
                    {
                        float timerFloat = Mathf.Round(rampageScript.cooldownTimer * 10) / 10;
                        text.text = timerFloat.ToString();
                    }
                    else
                    {
                        text.text = "";
                    }
                }
                break;


        }

        
    }
}
