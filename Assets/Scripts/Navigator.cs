using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Navigator : MonoBehaviour
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
 

    
   public void SetInputText(string name)
   {
       Debug.Log(name);
       
     
   }
   
   public void namecheck1 (string name){
       
   if (name == "Victor Castañeda" || name == "Suguru Kamoshida" || name == "Ichiryusai Madarame" || name == "Dio Brando" || name == "Sebastián Zepeda Castellanos" || name == "RTGame Daniel" || name == "Junya Kaneshiro" || name == "Deimos"){
       _correctname = true;
       Debug.Log("Target Found");
       lastname.text = name;
       
        if (name == "Victor Castañeda") {
        name = "Victor Castañeda";
        }
    if (name == "Suguru Kamoshida") {
        name = "Suguru Kamoshida";
        }
    if (name == "Ichiryusai Madarame") {
        name = "Ichiryusai Madarame";
        }
     if (name == "Dio Brando") {
        name = "Dio Brando";
        }
    if (name == "Sebastián Zepeda Castellanos") {
        name = "Sebastián Zepeda Castellanos";
        }
    if (name == "RTGame Daniel"){
        name = "RTGame Daniel";
    }
    if (name == "Junya Kaneshiro"){
        name = "Junya Kaneshiro";
        }
    if (name == "Deimos"){
        name = "Deimos";
        }
    if (name == "Triza"){
        name = "Triza";
        }
    }
    
    else {
        
        _correctname = false;
        }
     if (_correctname == true){
           
           Debug.Log("True");
           }
    
    }
    
    public void placecheck1 (string place){
       
   if (place == "San Patricio Plus Calle zircon" || place == "Shujin Academy" || place == "Shack" || place == "Cairo" || place == "Tec de Monterrey Campus Saltillo"|| place == "Mementos" || place == "Dublin Spire" || place == "Shibuya" || place == "Deimos' House"){
       _correctplace = true;
       Debug.Log("Place Found");
       lastplace.text = place;
       
       if (place == "San Patricio Plus Calle zircon") {
        place = "San Patricio Plus Calle zircon";
        }
    if (place == "Shujin Academy") {
        place = "Shujin Academy";
        }
    if (place == "Shack") {
        place = "Shack";
        }
    if (place == "Cairo") {
        place = "Cairo";
        }
    if (place == "Tec de Monterrey Campus Saltillo") {
        place = "Tec de Monterrey Campus Saltillo";
        }
    if (place == "Dublin Spire"){
        place = "Dublin Spire";
        }
    if (place == "Shibuya"){
        place = "Shibuya";
        }
    if (place == "Deimos' House"){
        place = "Deimos' House";
    if (place == "UIW")
                {
                    place = "UIW";
                }
        }
    }
    
    else {
        
        _correctplace = false;
        }
     if (_correctplace == true){
           
           Debug.Log("True Place");
           }
    
  }
    
    public void distortcheck1 (string distortion){
       
   if (distortion == "Hanekawa" || distortion == "Castle" || distortion == "Museum" || distortion == "Temple" || distortion == "Vault" || distortion == "Telethon Building" || distortion == "Bank" || distortion == "Fortress" || distortion == "Bakugou"){
       _correctdistortion = true;
       Debug.Log("Distortion Found");
       lastdistortion.text = distortion;
       
        if (distortion == "Hanekawa") {
        distortion = "Hanekawa";
    }
    if (distortion == "Castle") {
        distortion = "Castle";
    }
    if (distortion == "Museum") {
        distortion = "Museum";
    }
    if (distortion == "Temple") {
        distortion = "Temple";
    }
    if (distortion == "Vault") {
        distortion = "Vault";
    }
    if (distortion == "Telethon Building"){
        distortion = "Telethon Building";
    }
    if (distortion == "Bank"){
        distortion = "Bank";
        }
    if (distortion == "Fortress"){
        distortion = "Fortress";
        }
    if (distortion == "Bakugou"){
        distortion = "Bakugou";
        }
    }
    
    else {
        _correctdistortion = false;
        
        }
     if (_correctdistortion == true){
           
           Debug.Log("True distortion");
           }
           
   
    }
    
   
    public void mementos (string place){
       
   if (place == "Mementos"){
       _correctdistortion = true;
       _correctname = true;
       _correctplace = true;
       Debug.Log("Distortion Found");
       lastplace.text = place;
    }
    

    }

    public void CheckCandidate () {
            
        
        if (_correctname == true && _correctplace == true && _correctdistortion == true){
            
            Debug.Log("Candidate Found");
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();
          
            }
        else {
            _correctdistortion = false;
            _correctname = false;
            _correctplace = false;
            distortion = "";
            name = "";
            place = "";
        }
        }
            
        
        
     // public void SetHistoryname(string name){
    //    lastname.text = name;
  //      }
 //      public void SetHistoryplace(string place){
   //     lastplace.text = place;
  //      }
 //       public void SetHistorydistort(string distortion){
  //      lastdistortion.text = distortion;
        
   //     }
        
        public void CheckVariablename(string name){
            
        
        Debug.Log(name);
        }
        public void CheckVariablePlace(string place){
            
        Debug.Log(place);
        }
        public void CheckVariableDistort(string distortion){
        Debug.Log(distortion);
        
        }
}