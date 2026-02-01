using UnityEngine;
using UnityEngine.SceneManagement;

public class CardUp : MonoBehaviour
{
    public Animator anim;
    public string closedStateName = "test2";

    private bool isOpen = false;
    private string openFlapStateName = "";

    public bool IsOpen()
    {
        return isOpen;
    }

    public void LeftClickFlap(string flapStateName)
    {
        if (isOpen == false)
        {
            anim.Play(flapStateName);
            isOpen = true;
            openFlapStateName = flapStateName;
            return;
        }

        if (isOpen == true && openFlapStateName == flapStateName)
        {
            anim.Play(closedStateName);
            isOpen = false;
            openFlapStateName = "";
            return;
        }
    }

    public void ConfirmGiveToCop(GameObject clickedFlap)
    {
        if (isOpen == false) return;

        if (clickedFlap.CompareTag("ID"))
        {
            Debug.Log("good");
            FindFirstObjectByType<BadOGood>().LoadGoodEnding();
        }
        else
        {
            Debug.Log("bad");
            FindFirstObjectByType<BadOGood>().LoadBadEnding();
           

        }
    }
}
