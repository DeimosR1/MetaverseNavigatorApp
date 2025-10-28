using UnityEngine;
using UnityEngine.UI;

public class SNavigator : MonoBehaviour
{
    public bool _correctname = false;
    public bool _correctplace = false;
    public bool _correctdistorsion = false;

    public AudioClip CandidateFound;
    public AudioSource playAudio;

    public string name = "";
    public string place = "";
    public string distortion = "";

    public Text lastname;
    public Text lastplace;
    public Text lastdistorsion;

    public void NameCheck(string name)
    {
        switch (name)
        {
            case "Deimos R.":
                name = "Deimos R.";
                lastname.text = name;
                _correctname = true;
                break;

            case "Triza Chavez":
                name = "Triza Chavez";
                lastname.text = name;
                _correctname = true;
                break;


            case "Suguru Kamoshida":
                name = "Suguru Kamoshida";
                lastname.text = name;
                _correctname = true;
                break;


            case "Ichiryusai Madarame":
                name = "Ichiryusai Madarame";
                lastname.text = name;
                _correctname = true;
                break;

            case "Junya Kaneshiro":
                name = "Junya Kaneshiro";
                lastname.text = name;
                _correctname = true;
                break;

            case "Victor Castaneda":
                name = "Victor Castaneda";
                lastname.text = name;
                _correctname = true;
                break;



            default:
                name = "";
                lastname.text = name;
                _correctname = false;
                break;
        }
    }

    public void PlaceCheck(string place)
    {
        switch (place)
        {
            case "Dorms":
                place = "Dorms";
                lastplace.text = place;
                _correctplace = true;
                break;

            case "UIW":
                place = "UIW";
                lastplace.text = place;
                _correctplace = true;
                break;


            case "Shujin Academy":
                place = "Shujin Academy";
                lastplace.text = place;
                _correctplace = true;
                break;


            case "Shack":
                place = "Shack";
                lastplace.text = place;
                _correctplace = true;
                break;

            case "Shibuya":
                place = "Shibuya";
                lastplace.text = place;
                _correctplace = true;
                break;

            case "San Patricio Plus Calle zircon":
                place = "San Patricio Plus Calle zircon";
                lastplace.text = place;
                _correctplace = true;
                break;

            case "Mementos":
                place = "Mementos";
                lastplace.text = place;
                lastname.text = "";
                lastdistorsion.text = "";
                _correctplace = true;
                _correctname = true;
                _correctdistorsion = true;
                break;


            default:
                place = "";
                lastplace.text = place;
                _correctplace = false;
                break;
        }
    }

    public void DistortCheck(string distorsion)
    {
        switch (distorsion)
        {
            case "Courthouse":
                distorsion = "Courthouse";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;

            case "Bakugou":
                distorsion = "Bakugou";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;


            case "Castle":
                distorsion = "Castle";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;


            case "Museum":
                distorsion = "Museum";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;

            case "Vault":
                distorsion = "Vault";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;

            case "Hanekawa":
                distorsion = "Hanekawa";
                lastdistorsion.text = distorsion;
                _correctdistorsion = true;
                break;

            default:
                distorsion = "";
                lastdistorsion.text = distorsion;
                _correctdistorsion = false;
                break;
        }
    }

    public void CheckCandidate()
    {


        if (_correctname == true && _correctplace == true && _correctdistorsion == true)
        {

            Debug.Log("Candidate Found");
            _correctdistorsion = false;
            _correctname = false;
            _correctplace = false;
            playAudio.Play();

        }
        else
        {
            _correctdistorsion = false;
            _correctname = false;
            _correctplace = false;
            distortion = "";
            name = "";
            place = "";
        }
    }

}
