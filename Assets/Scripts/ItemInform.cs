using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInform : MonoBehaviour
{
    public int itemtype;
    public string needName = "";
    public string dialogueNum = "";
    public string sceneName;
    private void Start()
    {

    }
    private void OnEnable()
    {
        Messenger.AddListener<string>(Events.Epressed, action);
    }
    private void OnDisable()
    {
        Messenger.RemoveListener<string>(Events.Epressed, action);
    }
    void action(string name)
    {

        if (gameObject.name == name)
        {
            if (itemtype == 0)
            {
                //如果是0，捡起
                if (needName == "")
                {
                    //如果无需求，捡起
                    Messenger.Broadcast<string, Sprite>(Events.itemget, gameObject.name, GetComponent<SpriteRenderer>().sprite);
                    Destroy(this.gameObject);
                    Messenger.Broadcast<string>(Events.EventHappened, name);
                }
                else
                {
                    bool hasPickedUp = false;
                    for (int i = 1; i < 8; i++)
                    {
                        //判断物品栏内是否有物品
                        GameObject invTemp = GameObject.Find("Inv" + i);
                        if (needName == invTemp.GetComponent<InventoryInform>().itemName)
                        {
                            //捡起，发对话框，背包
                            Messenger.Broadcast<string, Sprite>(Events.itemget, gameObject.name, GetComponent<SpriteRenderer>().sprite);
                            hasPickedUp = true;
                            GameObject.Find("EName").gameObject.SetActive(false);
                            Messenger.Broadcast<string>(Events.EventHappened, name);
                            Destroy(this.gameObject);
                        }
                    }
                    //捡不起，发对话框
                    if (!hasPickedUp) Messenger.Broadcast<string>(Events.Dialogue, dialogueNum);

                }

            }
            if (itemtype == 1)
            {
                if(needName == "")
                {
                    GetComponent<ChangeSprite>().Changesprite();
                }
                else
                {
                    bool haschanged = false;
                    for (int i = 1; i < 8; i++)
                    {
                        GameObject invTemp = GameObject.Find("Inv" + i);
                        if (needName == invTemp.GetComponent<InventoryInform>().itemName)
                        {
                            haschanged = true;                            
                            GetComponent<ChangeSprite>().Changesprite();
                        }
                    }
                    if (!haschanged) Messenger.Broadcast<string>(Events.Dialogue, dialogueNum);
                }

            }
            if (itemtype == 2)
            {
                //门，房间=2
                if (needName == "")
                {
                    //无需求，进
                    Messenger.Broadcast<string,string>(Events.changeScene, sceneName, GetComponent<DoorInform>().doorDir);
                }
                else
                {
                    //有需求
                    bool isEntered = false;
                    for (int i = 1; i < 8; i++)
                    {
                        //检测
                        GameObject invTemp = GameObject.Find("Inv" + i);
                        if (needName == invTemp.GetComponent<InventoryInform>().itemName)
                        {
                            //进去了
                            Messenger.Broadcast<string,string>(Events.changeScene, sceneName, GetComponent<DoorInform>().doorDir);
                            Messenger.Broadcast<string>(Events.Usingitem, needName);
                            needName = "";
                            i = 10;
                            isEntered = true;
                        }
                    }
                    //进不去,爬，对话框
                    if(!isEntered) Messenger.Broadcast<string>(Events.Dialogue, dialogueNum);
                }
            }
        }
    }
}
