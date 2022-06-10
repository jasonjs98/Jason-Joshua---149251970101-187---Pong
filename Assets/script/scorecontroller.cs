using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecontroller : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;
    public scoremanager manager;
    // Start is called before the first frame update
    private void Update()
    {
        skorKiri.text = manager.leftscore.ToString();
        skorKanan.text = manager.rightscore.ToString();
    }
}
