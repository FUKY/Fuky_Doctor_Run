using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResourceController : Singleton<ResourceController>
{
    private string MEDICINE_PATH = "Enviroment/Game/Medicine";
    public Dictionary<int, Sprite> MedicineLibrary;

    void Start()
    {
        //MedicineLibrary = new Dictionary<int, Sprite>();
    }

    public void InitData()
    {
        MedicineLibrary = new Dictionary<int, Sprite>();
        LoadData(ref MedicineLibrary, MEDICINE_PATH);
    }

    public void LoadData(ref Dictionary<int, Sprite> dicSprites, string path)
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>(path);
        int index = 0;
        foreach(Sprite sprite in sprites)
        {
            MedicineLibrary.Add(index, sprite);
            index++;
        }
    }
}
