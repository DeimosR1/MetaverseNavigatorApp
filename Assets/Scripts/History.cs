using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class History : MonoBehaviour
{
    public Text lastname;
    public Text lastplace;
    public Text lastdistortion;
 
 
    void Start()
    {
        PlayerPrefs.SetString("LastName", FindFirstObjectByType<SNavigator>().name);
        lastname.text = PlayerPrefs.GetString("LastName");
        PlayerPrefs.SetString("LastPlace", FindFirstObjectByType<SNavigator>().place);
        lastplace.text = PlayerPrefs.GetString("LastPlace");
        PlayerPrefs.SetString("LastDistorsion", FindFirstObjectByType<SNavigator>().distortion);
        lastdistortion.text = PlayerPrefs.GetString("LastDistorsion");

     
     }
}
