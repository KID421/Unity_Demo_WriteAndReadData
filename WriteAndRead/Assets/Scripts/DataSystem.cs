using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DataSystem : MonoBehaviour
{
    public static PlayerData data = new PlayerData();

    public static DataSystem instanct;

    private Transform player;

    private void Start()
    {
        if (!instanct) instanct = this;

        DontDestroyOnLoad(gameObject);
    }

    public void SaveData()
    {
        string json = JsonUtility.ToJson(data);

        PlayerPrefs.SetString("資料儲存", json);
    }

    public void LoadData()
    {
        string json = PlayerPrefs.GetString("資料儲存");

        data = JsonUtility.FromJson<PlayerData>(json);

        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        yield return new WaitForSeconds(1);

        player = FindObjectOfType<Movement>().transform;
        print(data.coin);
        SetData();
    }

    private void SetData()
    {
        //player.position = data.tra.position;
        //player.rotation = data.tra.rotation;
        player.GetComponent<Movement>().data.coin = data.coin;
    }
}
