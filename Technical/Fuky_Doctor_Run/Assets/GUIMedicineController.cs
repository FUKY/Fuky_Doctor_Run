using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUIMedicineController : MonoBehaviour {

    private int MedicineCount;
    public Image[] medecineSlot;

    void Start()
    {
        ResourceController.Instance.InitData();
        MedicineCount = ResourceController.Instance.MedicineLibrary.Count;
    }

    [ContextMenu("Test")]
    public void RandomSlot()
    {
        if (MedicineCount == 0)
        {
#if UNITY_EDITOR    
            Debug.LogError("Khong load duoc du lieu");
#endif
            return;
        }
        int index = Random.Range(1, MedicineCount);
        foreach (Image item in medecineSlot)
        {
            item.sprite = ResourceController.Instance.MedicineLibrary[index];
            index = Random.Range(0, MedicineCount);
        }
    }
}
