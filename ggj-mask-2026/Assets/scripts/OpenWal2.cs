using UnityEngine;

public class OpenWal2 : MonoBehaviour
{
    public Transform card;
   public Transform wf;

    private string nameOfBlock;

    public float speed = 2f;
    public float maxUpDistance = 0.25f;

    public CardUp CU;
    public string flapStateName;

    private Vector3 cardStartLocalPos;
    private float maxX;

    private float maxWY;
    private Vector3 walletFlapStartLocalPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameOfBlock = gameObject.name;

        cardStartLocalPos = card.localPosition;
        walletFlapStartLocalPos = wf.localPosition;
 
        maxX = cardStartLocalPos.x + maxUpDistance;
        maxWY = walletFlapStartLocalPos.y -  maxUpDistance;

    }



    void OnMouseOver()
    {


        Debug.Log("mouse is over obj" + gameObject.name);

        if (CU != null && CU.IsOpen() == true)
        {
            if (Input.GetMouseButtonDown(0))
                CU.ConfirmGiveToCop(card.gameObject);

            if (Input.GetMouseButtonDown(1))
                CU.LeftClickFlap(flapStateName);

            return;
        }


        Vector3 pos = card.localPosition;
        pos.x = Mathf.Min(pos.x + speed * Time.deltaTime, maxX);
        card.localPosition = pos;


        Vector3 pos2 = wf.localPosition;
        pos2.y = Mathf.Max(pos2.y - speed * Time.deltaTime, maxWY);
        wf.localPosition = pos2;

        if (Input.GetMouseButtonDown(1))
            CU.LeftClickFlap(flapStateName);
   

    }



    void OnMouseExit()
    {
        Debug.Log("not on obj");

        if (CU != null && CU.IsOpen() == true)
            return;

        card.localPosition = cardStartLocalPos;
        wf.localPosition = walletFlapStartLocalPos;
    }

}

