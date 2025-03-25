using TMPro;
using UnityEngine;

public class LevelSelectButtonManager : MonoBehaviour
{
    [SerializeField]int levelCount;
    [SerializeField]GameObject levelSelectButtonPrefeb;
    void Start()
    {
        for (int i = 0; i < levelCount; i++)
        {
            GameObject child = Instantiate(levelSelectButtonPrefeb);
            child.transform.SetParent(this.transform);

            string levelName = (i+1).ToString();

            SceneChangeManager sceneChangeManager = child.GetComponent<SceneChangeManager>();
            sceneChangeManager.sceneName = "Level " + levelName;

            GameObject childText = child.transform.transform.GetChild(0).gameObject;
            childText.GetComponent<TextMeshProUGUI>().text = levelName;
        }
    }
}
