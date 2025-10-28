using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class History : MonoBehaviour
{
 public Text lastname;
 public Text lastplace;
 public Text lastdistortion;
 
 
 void Start(){
     
     lastname.text = FindObjectOfType<Navigator>().name;
     lastplace.text = FindObjectOfType<Navigator>().place;
     lastdistortion.text = FindObjectOfType<Navigator>().distortion;
     
     }
}
