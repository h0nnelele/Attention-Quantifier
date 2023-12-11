using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using TMPro;

public class SendData : MonoBehaviour
{
    [SerializeField] GameObject frame0;
    [SerializeField] GameObject frame1;
    [SerializeField] GameObject frame2;
    [SerializeField] GameObject frame3;
    [SerializeField] GameObject frame4;
    [SerializeField] GameObject frame5;
    [SerializeField] GameObject frame6;
    [SerializeField] GameObject name;
    [SerializeField] GameObject age;
    [SerializeField] GameObject category;
    [SerializeField] GameObject validationText;
    [SerializeField] GameObject menuButon;
    //[SerializeField] TextMeshProUGUI timeZoneA;
    //[SerializeField] TextMeshProUGUI timeZoneB;
    //[SerializeField] TextMeshProUGUI timeZoneC;
    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSf2tPuTS3Laok2aozVWM3uG1bnRQnAeZDOwv1_vF-D3ZqcxBA/formResponse";

    // Start is called before the first frame update
    public void SaveData()
    {
        StartCoroutine("Post");
    }

    // Update is called once per frame
    IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1191027826", GalleryData.name);
        form.AddField("entry.1200851957", GalleryData.age);
        form.AddField("entry.1737831720", GalleryData.category);
        form.AddField("entry.891012784", GalleryData.frame0_count);
        form.AddField("entry.1338617003", GalleryData.frame0_time);
        form.AddField("entry.1460887531", GalleryData.frame0_score);
        form.AddField("entry.1903115053", GalleryData.frame1_count);
        form.AddField("entry.531989891", GalleryData.frame1_time);
        form.AddField("entry.2023059001", GalleryData.frame1_score);
        form.AddField("entry.328469130", GalleryData.frame2_count);
        form.AddField("entry.1678534542", GalleryData.frame2_time);
        form.AddField("entry.2079997712", GalleryData.frame2_score);
        form.AddField("entry.1393976046", GalleryData.frame3_count);
        form.AddField("entry.158058392", GalleryData.frame3_time);
        form.AddField("entry.1885525233", GalleryData.frame3_score);
        form.AddField("entry.145246714", GalleryData.frame4_count);
        form.AddField("entry.1956038320", GalleryData.frame4_time);
        form.AddField("entry.135635444", GalleryData.frame4_score);
        form.AddField("entry.444097635", GalleryData.frame5_count);
        form.AddField("entry.1281168178", GalleryData.frame5_time);
        form.AddField("entry.2009934222", GalleryData.frame5_score);
        form.AddField("entry.624687302", GalleryData.frame6_count);
        form.AddField("entry.431808679", GalleryData.frame6_time);
        form.AddField("entry.740864523", GalleryData.frame6_score);
       //https://docs.google.com/forms/d/e/1FAIpQLSf2tPuTS3Laok2aozVWM3uG1bnRQnAeZDOwv1_vF-D3ZqcxBA/viewform?usp=pp_url&entry.56013640=busstopC&entry.1561900786=busstopT&entry.1018402309=busstopS&
              //entry.868091585=beeradC&entry.14559999=beeradT&entry.273743286=beeradS&entry.609016728=beer1C&entry.685194456=beer1T&entry.33803139=beer1S&entry.718834415=beer2C&
              //entry.1320053320=beer2T&entry.1296459738=beer2S&entry.2120620226=hhC&entry.1590095541=hhT&entry.500483561=hhS&entry.1769282883=cC&entry.1945646810=cT&entry.1620584564=cS&
              //entry.1462270299=wC&entry.1986783270=wT&entry.1665527893=wS&entry.1190684536=saladC&entry.1438549692=saladT&entry.1471280399=saladS&entry.77486415=soupC&entry.1592609484=soupT&
              //entry.1272974715=soupS&entry.1699280049=dessertC&entry.515375798=dessertT&entry.1870730857=dessertS&entry.1844557209=burC&entry.1389873069=burT&entry.366730473=burS&
              //entry.98666918=pC&entry.1681125470=pT&=pS
        form.AddField("entry.56013640", StreetData.busstop_count);
        form.AddField("entry.1561900786", StreetData.busstop_time);
        form.AddField("entry.1018402309", StreetData.busstop_score);
        form.AddField("entry.868091585", StreetData.beerad_count);
        form.AddField("entry.14559999", StreetData.beerad_time);
        form.AddField("entry.273743286", StreetData.beerad_score);
        form.AddField("entry.609016728", StreetData.beer1_count);
        form.AddField("entry.685194456", StreetData.beer1_time);
        form.AddField("entry.33803139", StreetData.beer1_score);
        form.AddField("entry.718834415", StreetData.beer2_count);
        form.AddField("entry.1320053320", StreetData.beer2_time);
        form.AddField("entry.1296459738", StreetData.beer2_score);
        form.AddField("entry.2120620226", StreetData.happyhour_count);
        form.AddField("entry.1590095541", StreetData.happyhour_time);
        form.AddField("entry.500483561", StreetData.happyhour_score);


        form.AddField("entry.1769282883", frame0.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1945646810", frame0.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.1620584564", frame0.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.1462270299", frame1.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1986783270", frame1.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.1665527893", frame1.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.1190684536", frame2.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1438549692", frame2.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.1471280399", frame2.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.77486415", frame3.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1592609484", frame3.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.1272974715", frame3.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.1699280049", frame4.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.515375798", frame4.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.1870730857", frame4.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.1844557209", frame5.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1389873069", frame5.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.366730473", frame5.GetComponent<DisplayResults>().score.text);
        form.AddField("entry.98666918", frame6.GetComponent<DisplayResults>().count.text);
        form.AddField("entry.1681125470", frame6.GetComponent<DisplayResults>().time.text);
        form.AddField("entry.491603681", frame6.GetComponent<DisplayResults>().score.text);
        Debug.Log("choubadoubadoub1");

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        Debug.Log("choubadoubadoub2");
        yield return www.SendWebRequest();
        Debug.Log("choubadoubadoub3");
        validationText.gameObject.SetActive(true);
        menuButon.gameObject.SetActive(true);


    }

    public void LoadScene1()
    {
        GalleryData.name = name.GetComponent<TMP_InputField>().text;
        GalleryData.age = age.GetComponent<TMP_InputField>().text;
        GalleryData.category = category.GetComponent<TMP_Text>().text;
        GalleryData.frame0_count = frame0.GetComponent<DisplayResults>().count.text;
        GalleryData.frame0_time = frame0.GetComponent<DisplayResults>().time.text;
        GalleryData.frame0_score = frame0.GetComponent<DisplayResults>().score.text;
        GalleryData.frame1_count = frame1.GetComponent<DisplayResults>().count.text;
        GalleryData.frame1_time = frame1.GetComponent<DisplayResults>().time.text;
        GalleryData.frame1_score = frame1.GetComponent<DisplayResults>().score.text;
        GalleryData.frame2_count = frame2.GetComponent<DisplayResults>().count.text;
        GalleryData.frame2_time = frame2.GetComponent<DisplayResults>().time.text;
        GalleryData.frame2_score = frame2.GetComponent<DisplayResults>().score.text;
        GalleryData.frame3_count = frame3.GetComponent<DisplayResults>().count.text;
        GalleryData.frame3_time = frame3.GetComponent<DisplayResults>().time.text;
        GalleryData.frame3_score = frame3.GetComponent<DisplayResults>().score.text;
        GalleryData.frame4_count = frame4.GetComponent<DisplayResults>().count.text;
        GalleryData.frame4_time = frame4.GetComponent<DisplayResults>().time.text;
        GalleryData.frame4_score = frame4.GetComponent<DisplayResults>().score.text;
        GalleryData.frame5_count = frame5.GetComponent<DisplayResults>().count.text;
        GalleryData.frame5_time = frame5.GetComponent<DisplayResults>().time.text;
        GalleryData.frame5_score = frame5.GetComponent<DisplayResults>().score.text;
        GalleryData.frame6_count = frame6.GetComponent<DisplayResults>().count.text;
        GalleryData.frame6_time = frame6.GetComponent<DisplayResults>().time.text;
        GalleryData.frame6_score = frame6.GetComponent<DisplayResults>().score.text;
        Debug.Log("choubadoubadoub");
        if (GlobalTimeData.language == "spanish")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint spanish/street_view_spanish.unity");
        else if (GlobalTimeData.language == "french")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint french/street_view_french.unity");


    }
    public void LoadScene2()
    {
        StreetData.busstop_count = frame0.GetComponent<DisplayResults>().count.text;
        StreetData.busstop_time = frame0.GetComponent<DisplayResults>().time.text;
        StreetData.busstop_score = frame0.GetComponent<DisplayResults>().score.text;
        StreetData.beerad_count = frame1.GetComponent<DisplayResults>().count.text;
        StreetData.beerad_time = frame1.GetComponent<DisplayResults>().time.text;
        StreetData.beerad_score = frame1.GetComponent<DisplayResults>().score.text;
        StreetData.beer1_count = frame2.GetComponent<DisplayResults>().count.text;
        StreetData.beer1_time = frame2.GetComponent<DisplayResults>().time.text;
        StreetData.beer1_score = frame2.GetComponent<DisplayResults>().score.text;
        StreetData.beer2_count = frame3.GetComponent<DisplayResults>().count.text;
        StreetData.beer2_time = frame3.GetComponent<DisplayResults>().time.text;
        StreetData.beer2_score = frame3.GetComponent<DisplayResults>().score.text;
        StreetData.happyhour_count = frame4.GetComponent<DisplayResults>().count.text;
        StreetData.happyhour_time = frame4.GetComponent<DisplayResults>().time.text;
        StreetData.happyhour_score = frame4.GetComponent<DisplayResults>().score.text;
        Debug.Log("choubadoubadoub");
        if (GlobalTimeData.language == "spanish")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint spanish/bar_spanish.unity");
        else if (GlobalTimeData.language == "french")
            SceneManager.LoadScene("Assets/Scenes/All scenes/no hint french/bar_french.unity");


    }
    public void LoadMain()
    {
        SceneManager.LoadScene("Assets/Scenes/All scenes/Language selection.unity");


    }
}
