using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetItem: MonoBehaviour
{
    public int getItemNum;
    [SerializeField]private TextMeshProUGUI tmp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        getItemNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int _getItemNum = 4 - getItemNum;
        tmp.text = _getItemNum.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            getItemNum++;
            Destroy(other.gameObject);
        }

        if(getItemNum >= 4)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }

    void GetItems()
    {
        
    }
}
