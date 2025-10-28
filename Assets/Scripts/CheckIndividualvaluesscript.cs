using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckIndividualvaluesscript : MonoBehaviour
{
    
    public bool _correctname = false;
    public bool _correctplace = false;
    public bool _correctdistortion = false;
    
    public AudioClip CandidateFound;
    public AudioSource playAudio;
    
    public string name = "";
    public string place = "";
    public string distortion = "";
    
    public Text lastname;
    public Text lastplace;
    public Text lastdistortion;

public void Check(){
    
if (place == "Mementos"){
            
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "Victor Castañeda" && place == "San Patricio Plus Calle zircon" && distortion == "Hanekawa"){
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
            }
            else  if (name == "Suguru Kamoshida" && place == "Shujin Academy" && distortion == "Castle"){
                Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
            }
            
            else  if (name == "Ichiryusai Madarame" && place == "Shack" && distortion == "Museum"){
            
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "Dio Brando" && place == "Cairo" && distortion == "Temple"){
            
    
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "Sebastián Zepeda Castellanos" && place == "Tec de Monterrey Campus Saltillo" && distortion == "Vault"){
       
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "RTGame Daniel" && place == "Dublin Spire" && distortion == "Telethon Building"){
       
            
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "Junya Kaneshiro" && place == "Shibuya" && distortion == "Bank"){
            
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
            else if (name == "Triza" && place == "UIW" && distortion == "Bakugou")
            {

                Debug.Log("Candidate Found");
                _correctdistortion = false;
                _correctname = false;
                _correctplace = false;
                playAudio.Play();

            }

        else if (_correctdistortion == false || _correctname == false || _correctplace == false){
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            distortion = "";
            name = "";
            place = "";
        }
       }
       } 
        