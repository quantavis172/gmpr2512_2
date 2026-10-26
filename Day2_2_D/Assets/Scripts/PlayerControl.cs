using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Rigidbody2D ball;
    [SerializeField] HingeJoint2D leftFlipper, rightFlipper;
    [SerializeField] GameObject launcher, upperLimit, lowerLimit;

    public bool canLaunch;
    [SerializeField] float launcherSpeedDown, launcherSpeedUp, launcherForce;

    float launchDistance;
    public bool isLaunched, flippersActive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //canLaunch = true;
        isLaunched = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.sKey.isPressed && canLaunch)
        {
            if (isLaunched && canLaunch)
            {
                isLaunched = false;
            }

            launcher.transform.Translate(Vector2.down * Time.deltaTime * launcherSpeedDown);

            if (launcher.transform.position.y < lowerLimit.transform.position.y)
            {
                launcher.transform.position = new Vector2(launcher.transform.position.x, lowerLimit.transform.position.y);
            }

            launchDistance = Vector2.Distance(launcher.transform.position, upperLimit.transform.position);
        }
        else
        {
            if (launcher.transform.position.y < upperLimit.transform.position.y)
            {
                launcher.transform.Translate(Vector2.up * Time.deltaTime * launcherSpeedUp);
            }
            else
            {
                if (!isLaunched && canLaunch)
                {
                    ball.AddForce(Vector2.up * launcherForce * launchDistance, ForceMode2D.Impulse);
                    isLaunched = true;
                }
            }

            if (launcher.transform.position.y > upperLimit.transform.position.y)
            {
                launcher.transform.position = new Vector2(launcher.transform.position.x, upperLimit.transform.position.y);
            }
        }
        //exit game
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
        //flippers

        // Left Flipper
        JointMotor2D leftMotor = leftFlipper.motor;

        if (flippersActive)
        {
            if (Keyboard.current.aKey.isPressed)
            {
                leftMotor.motorSpeed = -10000f;
            }
            else
            {
                leftMotor.motorSpeed = 10000f;
            }

            leftFlipper.motor = leftMotor;
            leftFlipper.useMotor = true;
        }
        else
        {
            leftFlipper.useMotor = false;
        }

        // Right Flipper
        JointMotor2D rightMotor = rightFlipper.motor;

        if (flippersActive)
        {
            if (Keyboard.current.dKey.isPressed)
            {
                rightMotor.motorSpeed = 10000f;
            }
            else
            {
                rightMotor.motorSpeed = -10000f;
            }

            rightFlipper.motor = rightMotor;
            rightFlipper.useMotor = true;
        }
        else
        {
            rightFlipper.useMotor = false;
        }
        
    
      }
    } 