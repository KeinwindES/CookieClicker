using UnityEngine;
using UnityEngine.UI;

public class CookieCount : MonoBehaviour
{
    public int cookieCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        // click to increase cookie count
        On Click()
        {
            cookieCount++;
        }
    }
}