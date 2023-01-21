using System.Collections;
using System.Collections.Generic;
using GR;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Vuforia;

namespace Experiments
{
    //! Apenas os gestos de Pinça devem ser utilizados
    class Experimento01 : MonoBehaviour
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
        [SerializeField] float _MinZWidth = -24.0f;
        [SerializeField] float _MaxZWidth = -8.0f;

        //Número máximo de objetos do experimento
        int _MaxSceneObjects = 2;
        int _childrenCount = 0;
        public int childrenCount
        {
            get { return this._childrenCount; }
            set { this._childrenCount = value; }
        }

        //Variáveis para armazenamento e manipulação dos objeto em cena
        [SerializeField] GameObject[] _prefabObjects;
        [SerializeField] GameObject[] _prefabObjectives;
        List<GameObject> _objects;
        List<GameObject> _objectives;
        Material[] _objColors;

        //! Indicadores do Experimento 01
        [SerializeField] GameObject _collisionPanelPrefab;
        Text[] _collisionInfo;
        public Text thumbCollisionInfo
        {
            get { return this._collisionInfo[2]; }
            set { this._collisionInfo[2] = value; }
        }
        public Text indexCollisionInfo
        {
            get { return this._collisionInfo[0]; }
            set { this._collisionInfo[0] = value; }
        }
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
            GameObject _collisionInfoObj = Instantiate(_collisionPanelPrefab, canvas.transform);
            _collisionInfoObj.name = _collisionPanelPrefab.name;
            _collisionInfo = new Text[2];
            _collisionInfo[0] = _collisionInfoObj.transform.GetChild(0).GetComponent<Text>(); //Polegar
            _collisionInfo[1] = _collisionInfoObj.transform.GetChild(2).GetComponent<Text>(); //Indicador

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

            //Resetando o texto de colisão
            this._collisionInfo[0].text = "Indicador: sem nenhuma colisão";
            this._collisionInfo[1].text = "Polegar: sem nenhuma colisão";

            //Inicializando os objetos necessários
            _objects = new List<GameObject>();
            _objectives = new List<GameObject>();

            //Gerando os objetos em cena, com base no valor máximo definido acima
            bool alternatePos = false;
            for (int i = 0; i < _MaxSceneObjects; i++)
            {
                //Alterar posição dos objetos instanciados logo abaixo
                alternatePos = !alternatePos;

                //! Considerando o marcador no canto esquerdo e deitado
                //Definindo as posições dos objetos e alvos, com base no tamanho do cenário
                Vector3 posObject = new Vector3(
                    (alternatePos ? _MinXLength : _MaxXLength),
                    _MaxYHeight,
                    (alternatePos ? _MinZWidth : _MaxZWidth));

                Vector3 posObjective = new Vector3(0.0f, _MaxYHeight, -10.0f * (alternatePos ? 1 : 2.0f));

                Debug.Log("DistânciaExp01: " + Vector3.Distance(posObject, posObjective));

                //Material para cada objeto
                Material material = _objColors[Random.Range(0, _objColors.Length)];

                _objects.Add(Instantiate(_prefabObjects[i], posObject, Quaternion.identity, this.GetComponent<ObserverBehaviour>().transform) as GameObject);
                _objects[i].name = _prefabObjects[i].name;
                _objects[i].GetComponent<MeshRenderer>().material = material;

                //_objectives.Add(Instantiate(_prefabObjectives[i], this.GetComponent<ObserverBehaviour>().transform) as GameObject);
                _objectives.Add(Instantiate(_prefabObjectives[i], posObjective, Quaternion.identity, this.GetComponent<ObserverBehaviour>().transform) as GameObject);
                _objectives[i].name = _prefabObjectives[i].name;
                _objectives[i].GetComponent<MeshRenderer>().material = material;
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
            switch (metrics.actualTestScene)
            {
                case 1:
                    _actualTestScene.text = "Executando: Cenário 01";
                    _MaxSceneObjects = 1;
                    break;
                case 2:
                    _actualTestScene.text = "Executando: Cenário 02";
                    _MaxSceneObjects = 2;
                    break;
            }
            generateObjects();

            //! Realizar os ciclos desejados para cada cenário
            while (metrics.cycleCount <= MaxCycle)
            {
                //Aguara os calculos de colisões
                yield return new WaitForFixedUpdate();

                //Recuperação da quantidade de objetos ainda na cena
                _childrenCount = this.transform.childCount;

                //! Término de um Teste, iniciar outro até a contagem de 5 do ciclo
                if (_childrenCount == 1 && transform.GetChild(0).name == "Plane")
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
                        Debug.Log("Término do Ciclo " + metrics.cycleCount);
                        yield return new WaitForSeconds(5.0f);
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

            yield return null;
        }

        IEnumerator countGestures()
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


        }


    }

}