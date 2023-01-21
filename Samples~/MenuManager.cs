using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    void Awake()
    {
        //Impossibilitando o aparelho de entrar em "modo repouso" (desligar tela)
        UnityEngine.Screen.sleepTimeout = SleepTimeout.NeverSleep;

        String sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Experimento01" || sceneName == "Experimento02")
        {
            //Recuperando um Canvas existente
            GameObject canvas = GameObject.Find("Canvas");
            if (canvas == null)
            {
                canvas = new GameObject("Canvas");
                Canvas canvasComponent = canvas.AddComponent<Canvas>();
                canvasComponent.renderMode = RenderMode.ScreenSpaceOverlay;
                //canvasComponent.renderMode = RenderMode.ScreenSpaceCamera;
                //canvasComponent.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
                canvas.AddComponent<CanvasScaler>();
                canvas.AddComponent<GraphicRaycaster>();

                GameObject eventSystem = GameObject.Find("EventSystem");
                if (eventSystem == null)
                {
                    eventSystem = new GameObject("EventSystem");
                    eventSystem.AddComponent<EventSystem>();
                    eventSystem.AddComponent<StandaloneInputModule>();
                }
            }

            //Após recuperar o Canvas, cria o botão para retornar no canto superior esquerdo
            GameObject btnReturnObj = DefaultControls.CreateButton(new DefaultControls.Resources());
            btnReturnObj.name = "BtnReturnMenu2";
            //btnReturnObj.transform.parent = canvas.transform;
            btnReturnObj.transform.SetParent(canvas.transform);

            btnReturnObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.0f, 1.0f);
            btnReturnObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.0f, 1.0f);
            btnReturnObj.GetComponent<RectTransform>().pivot = new Vector2(1.0f, 1.0f);
            btnReturnObj.GetComponent<RectTransform>().anchoredPosition = new Vector2(300.0f, -25.0f);
            btnReturnObj.GetComponent<RectTransform>().sizeDelta = new Vector2(280.0f, 150.0f);

            Text btnReturnText = btnReturnObj.transform.GetChild(0).gameObject.GetComponent<Text>();
            btnReturnText.text = "Retornar";
            btnReturnText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            btnReturnText.fontStyle = FontStyle.Normal;
            btnReturnText.fontSize = 20;
            btnReturnText.lineSpacing = 1;
            btnReturnText.supportRichText = true;
            btnReturnText.alignment = TextAnchor.MiddleCenter;
            btnReturnText.alignByGeometry = false;
            btnReturnText.horizontalOverflow = HorizontalWrapMode.Wrap;
            btnReturnText.verticalOverflow = VerticalWrapMode.Truncate;
            btnReturnText.resizeTextForBestFit = true;
            btnReturnText.color = Color.black; 
            btnReturnText.maskable = true;

            Button btnReturn = btnReturnObj.GetComponent<Button>();
            btnReturn.onClick.AddListener(returnMenu);
        }

    }

    void returnMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Scene");
    }

    public void SceneExp01()
    {
        SceneManager.LoadScene("Experimento01");
    }

    public void SceneExp02()
    {
        SceneManager.LoadScene("Experimento02");
    }
    
}
