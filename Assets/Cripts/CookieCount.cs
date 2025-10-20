using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CookieCount : MonoBehaviour
{
    public int cookieCount;

    // Support either legacy UI Text or TextMeshPro. Assign one in the Inspector.
    public TMP_Text countTMPText;

    void Start()
    {
        UpdateCountText();
    }

    // Call this from a UI Button OnClick() or other input handler
    public void OnClick()
    {
        cookieCount++;
        UpdateCountText();
    }

    void UpdateCountText()
    {
        string s = cookieCount.ToString();
        if (countTMPText != null)
        {
            countTMPText.text = s;
            return;
        }
    }
}