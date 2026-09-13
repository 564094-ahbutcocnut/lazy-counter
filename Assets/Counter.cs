using TMPro;
using UnityEngine;



public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counter;



    int countervalue = 0;

    void start()
    {
        counter.text = countervalue.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countervalue++;
            counter.text = countervalue.ToString();
        }
    }
}
