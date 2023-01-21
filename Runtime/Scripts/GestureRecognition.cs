using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Management;
using Vuforia;

// #if UNITY_EDITOR
// using UnityEditor;
// #endif

/// <summary>
///   Name
/// </summary>
namespace GR
{
    enum GestureType
    {
        None,
        Point,
        TweezersClose,
        TweezersCloseAndMove,
        TweezersOpen,
    }


    //Classe que infere uma ação, a partir do reconhecimento de gestos (distância entre centro da esfera dos marcadores)
    class GestureRecognition : MonoBehaviour
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Validation for Developer to View the Gesture Recognition Information in real-time
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [SerializeField] bool viewGestureInformation = true;
        public GameObject gestureInfoPanelPrefab = null;
        private Text _gestureInformation;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Cardboard HMD VST Output = Unity Mock HMD
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [SerializeField] private bool CardboardOutput = false;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //! Criação de alguns gestos previstos no Projeto
        //! - 1. Apontar (seleção simples de objeto - sem colisão direta)
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        IndexFingerTip _indexFingerTip; //Indicador
        public IndexFingerTip indexFingerTip
        {
            get { return _indexFingerTip; }
        }
        RaycastHit _indexHit; //Informações do raio de colisão a partir do indicador
        public RaycastHit indexHit
        {
            get { return _indexHit; }
        }
        bool _indexHitAnObject; //Controle de colisão com algum objeto
        public bool indexHitAnObject
        {
            get { return _indexHitAnObject; }
        }
        //LineRenderer _indexLine; //Linha de renderização do indicador para raio de colisão
        //private const float _lineDistance = 999999.0f; //Distância máxima da linha de renderização na cena

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //! Criação de alguns gestos previstos no Projeto
        //! - 2. Agarrar/Pinça Fechada (seleção de objeto - com colisão direta)
        //! -- 2.1. Agarrar e Mover (deslocar objeto no cenário)
        //! -- 2.2. Liberar/Pinça Aberta
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ThumbTip _thumbTip; //Polegar
        public ThumbTip thumbTip
        {
            get { return _thumbTip; }
        }

        //! Gesto ativo
        GestureType _activeGesture;
        public GestureType activeGesture
        {
            get { return _activeGesture; }
        }

        private void Awake()
        {
            //Não destrói esse objeto ao trocar de cenas (economia de memoria)
            //DontDestroyOnLoad(this.gameObject);
            //VuforiaApplication.Instance.Deinit();
            //VuforiaApplication.Instance.Initialize();

            //Recuperando o texto para visualização das informações, caso desejado pelo usuário
            if (viewGestureInformation)
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

                //Após recuperar o Canvas, cria o texto para as informações no canto superior direito
                if(gestureInfoPanelPrefab == null)
                {
                    GameObject textInfo = new GameObject("GestureInfo");
                    textInfo.transform.SetParent(canvas.transform);
                    textInfo.AddComponent<CanvasRenderer>();
                    this._gestureInformation = textInfo.AddComponent<Text>();

                    //Configuração do Texto
                    this._gestureInformation.rectTransform.anchorMin = new Vector2(1.0f, 1.0f);
                    this._gestureInformation.rectTransform.anchorMax = new Vector2(1.0f, 1.0f);
                    this._gestureInformation.rectTransform.pivot = new Vector2(1.0f, 1.0f);
                    this._gestureInformation.rectTransform.anchoredPosition = new Vector2(-200.0f, -100.0f);
                    this._gestureInformation.rectTransform.sizeDelta = new Vector2(400.0f, 400.0f);
                    this._gestureInformation.text = "Null"; //Texto inicial (quando não encontra gestos)
                    this._gestureInformation.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
                    this._gestureInformation.fontSize = 50;
                    this._gestureInformation.lineSpacing = 1;
                    this._gestureInformation.supportRichText = true;
                    this._gestureInformation.alignment = TextAnchor.UpperRight;
                    this._gestureInformation.alignByGeometry = false;
                    this._gestureInformation.horizontalOverflow = HorizontalWrapMode.Wrap;
                    this._gestureInformation.verticalOverflow = VerticalWrapMode.Overflow;
                    this._gestureInformation.color = Color.white;
                    this._gestureInformation.maskable = true;
                }
                else
                {
                    GameObject textInfo = Instantiate(gestureInfoPanelPrefab, canvas.transform);
                    this._gestureInformation = textInfo.GetComponentInChildren<Text>();
                }
                
                
            }

            //! Modo de Saída Cardboard: HMD VST
            if (CardboardOutput)
            {
                //Impossibilitando o aparelho de entrar em "modo repouso" (desligar tela)
                UnityEngine.Screen.sleepTimeout = SleepTimeout.NeverSleep;

                //Definir brilho no máximo
                Screen.brightness = 1.0f;
                
                //! Definindo a saída do Cardboard
                XRSettings.gameViewRenderMode = GameViewRenderMode.BothEyes;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //! Inicialização de Variáveis
            //! - 1. Apontar (seleção simples de objeto - sem colisão direta)
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            _indexFingerTip = GameObject.Find("M_Index_Finger_Tip").GetComponent<IndexFingerTip>();
            //_indexLine = GameObject.Find("M_Index_Finger_Tip").GetComponent<LineRenderer>();
            _indexHitAnObject = false;
            //_indexLine.enabled = false;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //! Inicialização de Variáveis
            //! - 2. Agarrar/Pinça Fechada (seleção de objeto - com colisão direta)
            //! -- 2.1. Agarrar e Mover (deslocar objeto no cenário)
            //! -- 2.2. Liberar/Pinça Aberta
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            _thumbTip = GameObject.Find("M_Thumb_Tip").GetComponent<ThumbTip>();

            //! Nenhum gesto ativo de início
            _activeGesture = GestureType.None;

        }

        //Avaliação dos gestos e execução das ações
        private void FixedUpdate()
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //! Identifcação dos Gestos e Suas Ações
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            GestureWithAction();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //! Identifcação dos Gestos e Suas Ações
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void GestureWithAction()
        {
            //! Verificando a presença de algum marcador na cena
            //Apontar
            if (_indexFingerTip.IsActive && !_thumbTip.IsActive)
            {
                _activeGesture = GestureType.Point;
                if(viewGestureInformation) _gestureInformation.text = "Apontar";
                applyRaycast(); //Aplicação de raio no eixo para infinito
            }
            //Pinças
            else if (_indexFingerTip.IsActive && _thumbTip.IsActive)
            {
                //if(_indexLine != null)
                //    _indexLine.enabled = false;
                //! Separação das Pinças para identificação acurada de gestos
                identifyTheTweezersType();
            }
            else
            {
                //if (_indexLine != null)
                //    _indexLine.enabled = false;
                _activeGesture = GestureType.None;
                if(viewGestureInformation) _gestureInformation.text = "Sem Gestos Rastreados";
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //! - 1. Apontar (seleção simples de objeto - sem colisão direta)
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Aplicação do raycast a partir da ponta dos dedos (marcador do indicador)
        private void applyRaycast()
        {
            //Eixo -X: Vector3.left
            Transform centerSphere = _indexFingerTip.Sphere.transform;
            //_indexLine.enabled = true;
            //_indexLine.SetPosition(0, centerSphere.position);

            //Configuração da física do raio da mão
            if (Physics.Raycast(centerSphere.position, centerSphere.TransformDirection(Vector3.left), out _indexHit, Mathf.Infinity))
            {
                Debug.Log("Raycast Hit! Object Hit: " + _indexHit.collider.name);
                //_indexLine.SetPosition(1, _indexHit.point);
                _indexHitAnObject = true;
                return;
            }

            _indexHitAnObject = false;
            //_indexLine.SetPosition(1, new Vector3(0, 0, _lineDistance));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //! - 2. Agarrar/Pinça Fechada (seleção de objeto - com colisão direta)
        //! -- 2.1. Agarrar e Mover (deslocar objeto no cenário)
        //! -- 2.2. Liberar/Pinça Aberta
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void identifyTheTweezersType()
        {
            float distBetweenLandmarks = Vector3.Distance(_indexFingerTip.Sphere.transform.position, _thumbTip.Sphere.transform.position);
            Debug.Log("Distance Markers: " + distBetweenLandmarks);

            //! Pinça Fechada
            if (distBetweenLandmarks < 4.0f)
            {
                //Verificando movimento da pinça fechada (apenas para indicação)
                StartCoroutine(checkMoving());
            }
            //! Pinça Aberta
            else
            {
                //Quando há pinça aberta, acabar com qualquer colisão (soltou objeto)
                _activeGesture = GestureType.TweezersOpen;
                if(viewGestureInformation) _gestureInformation.text = "Pinça Aberta";

            }
        }

        private IEnumerator checkMoving()
        {
            Vector3 startPos = _indexFingerTip.Sphere.transform.position;
            yield return new WaitForSeconds(1.0f);
            Vector3 finalPos = _indexFingerTip.Sphere.transform.position;

            //Caso as posições sejam diferentes, indica que o objeto se moveu, com base em uma margem de erro de posição
            //float error = 0.015f;
            float error = 0.9f;
            float distPos = Vector3.Distance(startPos, finalPos);
            Debug.Log("Distance Moving: " + distPos);

            if (distPos >= error)
            {
                _activeGesture = GestureType.TweezersCloseAndMove;
                if(viewGestureInformation) _gestureInformation.text = "Pinça Fechada e Mover";
            }
            else
            {
                _activeGesture = GestureType.TweezersClose;
                if(viewGestureInformation) _gestureInformation.text = "Pinça Fechada";
            }
        }

    }

    // #if UNITY_EDITOR
    //     [CustomEditor(typeof(GestureRecognition))]
    //     class GestureRecognition_Editor : Editor
    //     {
    //         public override void OnInspectorGUI()
    //         {
    //             DrawDefaultInspector(); // for other non-HideInInspector fields

    //             GestureRecognition options = (GestureRecognition)target;
    //             options.viewGestureInformation = EditorGUILayout.Toggle("View Gesture Information", options.viewGestureInformation);

    //             if (options.viewGestureInformation)
    //             {
    //                 options.gestureInfoPanelPrefab = EditorGUILayout.ObjectField("GestureInfoPanel Prefab", options.gestureInfoPanelPrefab, typeof(GameObject), true) as GameObject;
    //             }
    //             else
    //             {
    //                 options.gestureInfoPanelPrefab = null;
    //             }
    //         }
    //     }
    // #endif

}


