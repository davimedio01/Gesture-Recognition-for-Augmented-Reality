using System.Collections;
using System.Collections.Generic;
using GR;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Vuforia;

namespace Experiments
{
    class Experimento02 : MonoBehaviour
    {
        //! Importação do Reconhecedor de Gestos
        GestureRecognition gestureRecognition;

        //Dados dos experimentos
        public ExperimentsMetrics metrics = new ExperimentsMetrics();
        int MaxTestScene = 2;
        public int MaxCycle = 5;
        public int MaxExecution = 5;
        bool timeTracked;

        //Região máxima dos objetos, de acordo com experimentos
        //Comprimento: X
        [SerializeField] float _MinXLength = -6.0f;
        [SerializeField] float _MaxXLength = 6.0f;

        //Altura: Y
        [SerializeField] float _MinYHeight = 0.0f;
        [SerializeField] float _MaxYHeight = 2.0f;

        //Largura: Z 
        [SerializeField] float _MinZWidth = -8.0f;
        [SerializeField] float _MaxZWidth = -24.0f;

        //Número máximo de objetos do experimento
        int _MaxSceneObjects = 2;

        //Variáveis para armazenamento e manipulação dos objeto em cena
        [SerializeField] GameObject[] _prefabObjects;
        List<GameObject> _objects;
        int _objectiveIndex;
        Material[] _objColors;

        //! Indicador do Experimento 02
        [SerializeField] GameObject _objectivePanelPrefab;
        Text _objectiveInfo;
        [SerializeField] GameObject _actualTestSceneInfoPrefab;
        Text _actualTestScene;

        private void Awake()
        {
            //Recuperação do reconhecedor de gestos da cena

            gestureRecognition = GameObject.Find("Gesture Recognition").GetComponent<GestureRecognition>();

            //Adiciona um chão para posterior física
            GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane) as GameObject;
            floor.transform.SetParent(this.transform);
            Destroy(floor.GetComponent<MeshRenderer>() as MeshRenderer);
            floor.transform.localScale = new Vector3(15.0f, 1.0f, 15.0f);
            Rigidbody floorRigid = floor.AddComponent<Rigidbody>() as Rigidbody;
            floorRigid.isKinematic = true;
            floorRigid.useGravity = false;
            floorRigid.constraints = RigidbodyConstraints.FreezeAll;

            //Recuperando cores possíveis do objeto
            _objColors = Resources.LoadAll<Material>("Materials/General/");

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

            //Após recuperar o Canvas, instancia o texto para as informações no canto inferior central
            GameObject _objectiveInfoObj = Instantiate(_objectivePanelPrefab, canvas.transform);
            _objectiveInfoObj.name = _objectivePanelPrefab.name;
            _objectiveInfo = _objectiveInfoObj.transform.GetChild(1).GetComponent<Text>();

            //Após recuperar o Canvas, instancia o texto para as informações no canto inferior central
            GameObject _actualTestSceneInfoObj = Instantiate(_actualTestSceneInfoPrefab, canvas.transform);
            _actualTestSceneInfoObj.name = _actualTestSceneInfoPrefab.name;
            _actualTestScene = _actualTestSceneInfoObj.transform.GetChild(0).GetComponent<Text>();

            //Geração de objetos iniciais
            //generateObjects();
        }

        void generateObjects()
        {
            //Resetando a posição de mundo do marcador
            this.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

            //Inicializando os objetos necessários
            _objectiveIndex = 0;
            _objects = new List<GameObject>();

            //Gerando os três objetos em posições aleatórias máximas, com seus respectivos alvos/objetivos
            for (int i = 0; i < _MaxSceneObjects; i++)
            {
                //Posição aleatória do objeto
                Vector3 posObject = new Vector3(
                    Random.Range(_MinXLength, _MaxXLength),
                    _MaxYHeight, 
                    Random.Range(_MinZWidth, _MaxZWidth));

                //Material para cada objeto
                Material material = _objColors[Random.Range(0, _objColors.Length)];

                //Objeto pré-definido randômico
                int prefabIndex = Random.Range(0, _prefabObjects.Length);

                _objects.Add(Instantiate(_prefabObjects[prefabIndex], posObject, Quaternion.identity, this.GetComponent<ObserverBehaviour>().transform) as GameObject);
                _objects[i].name = _prefabObjects[prefabIndex].name;
                _objects[i].GetComponent<MeshRenderer>().material = material;
            }
        }

        private void Start()
        {
            //Relacionado às métricas
            timeTracked = false;

            //! Contador de Gestos para Métricas
            StartCoroutine(countGestures());

            //! Realização dos experimentos
            StartCoroutine(expExec());
        }

        IEnumerator expExec()
        {
            //! Realizar os cenários desejados
            while (metrics.actualTestScene <= MaxTestScene)
            {
                //! Definindo a quantidade de objetos por cenário
                switch (metrics.actualTestScene)
                {
                    case 1:
                        _actualTestScene.text = "Executando: Cenário 01";
                        _MaxSceneObjects = 2;
                        break;
                    case 2:
                        _actualTestScene.text = "Executando: Cenário 02";
                        _MaxSceneObjects = 5;
                        break;
                }
                generateObjects();

                //! Realizar os ciclos desejados para cada cenário
                while (metrics.cycleCount <= MaxCycle)
                {
                    //Aguara os calculos de colisões
                    yield return new WaitForFixedUpdate();

                    //! Objeto que deve ser indicado
                    if (_objectiveIndex < _MaxSceneObjects)
                    {
                        _objectiveInfo.text = _objects[_objectiveIndex].name;
                        _objectiveInfo.color = _objects[_objectiveIndex].GetComponent<MeshRenderer>().material.color;
                    }

                    //! Verificação da colisão com base no objeto desejado pelo sistema
                    if (gestureRecognition.indexHitAnObject && _objects != null && gestureRecognition.indexHit.transform != null)
                    {
                        Debug.Log("Acertou um Objeto do Cenário!");

                        //! Somente prossegue se a colisão foi com o objeto do objetivo
                        if (gestureRecognition.indexHit.transform.name == _objects[_objectiveIndex].name)
                        {
                            metrics.distanceError = gestureRecognition.indexHit.distance;
                            metrics.targetError = 0.0f;
                            Destroy(_objects[_objectiveIndex]);
                            _objectiveIndex++;
                        }
                        else
                        {
                            metrics.distanceError = 0.0f;
                            metrics.targetError = gestureRecognition.indexHit.distance;
                        }

                        if (_objectiveIndex < _MaxSceneObjects)
                        {
                            //! Último elemento do teste deve ser salvo com o tempo de término!
                            new ExperimentMetricsManager().SaveData(in metrics);
                        }
                    }

                    //! Término de um Teste, iniciar outro até a contagem de 5 do ciclo
                    if (_objectiveIndex == _MaxSceneObjects)
                    {
                        //Salva o tempo de fim de teste, após todas as físicas
                        metrics.timeScene = Time.fixedTime;

                        //Salvar as informações obtidas no arquivo
                        new ExperimentMetricsManager().SaveData(in metrics);

                        //! Iniciar outro teste até a contagem máxima
                        metrics.timeScene = 0.0f;
                        metrics.executionCount++;

                        //! Término de um ciclo. Aguardar 5 segundos e iniciar novamente
                        if (metrics.executionCount > MaxExecution)
                        {
                            Debug.Log("Término de Ciclo " + metrics.cycleCount);
                            yield return new WaitForSecondsRealtime(5.0f);
                            metrics.executionCount = 1;
                            metrics.cycleCount++;
                        }

                        //Aguardar antes de gerar de novo
                        yield return new WaitForEndOfFrame();

                        //Gerando os objetos da execução nova
                        if (metrics.cycleCount <= MaxCycle)
                        {
                            generateObjects();
                        }
                    }
                }

                //! Terminou o ciclo completo de um cenário, resetar variáveis e ir para outro
                yield return new WaitForSecondsRealtime(10.0f); //Aguardar 8s entre cenários
                metrics.actualTestScene++;
                metrics.timeScene = 0.0f;
                metrics.executionCount = 1;
                metrics.cycleCount = 1;
            }
            yield return null;
        }

        IEnumerator countGestures()
        {
            //! Realizar os cenários desejados
            while (metrics.actualTestScene <= MaxTestScene)
            {
                //! Realizar os ciclos desejados para cada cenário
                while (metrics.cycleCount <= MaxCycle)
                {
                    //Salvando tempo de reconhecer algum gesto
                    if (!timeTracked && gestureRecognition.activeGesture != GestureType.None)
                    {
                        metrics.timeRecognition = Time.fixedDeltaTime;
                        timeTracked = true;
                    }

                    //Salvando o gesto anterior para comparar com o atual
                    GestureType activeGesture = gestureRecognition.activeGesture;

                    yield return new WaitForSeconds(1.0f);

                    //Salvando contador com base no gesto atual e anterior reconhecidos
                    switch (gestureRecognition.activeGesture)
                    {
                        case GestureType.Point:
                            if (gestureRecognition.activeGesture != activeGesture)
                            {
                                metrics.countApontar++;
                            }
                            break;

                        case GestureType.TweezersClose:
                            if (gestureRecognition.activeGesture != activeGesture)
                            {
                                metrics.countPincaFechada++;
                            }
                            break;

                        case GestureType.TweezersCloseAndMove:
                            if (gestureRecognition.activeGesture != activeGesture)
                            {
                                metrics.countPincaFechadaMover++;
                            }
                            break;

                        case GestureType.TweezersOpen:
                            if (gestureRecognition.activeGesture != activeGesture)
                            {
                                metrics.countPincaAberta++;
                            }
                            break;
                    }
                }

                //! Reiniciando as variáveis para o próximo cenário
                timeTracked = false;
                metrics.timeRecognition = 0.0f;
                metrics.countApontar = 0;
                metrics.countPincaFechada = 0;
                metrics.countPincaFechadaMover = 0;
                metrics.countPincaAberta = 0;
            }

        }

    }
}