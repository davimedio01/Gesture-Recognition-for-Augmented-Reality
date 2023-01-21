using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace GR
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //! Criação de alguns gestos previstos no Projeto: sequenciais (só pode realizar as ações deles na sequência)
    //! - 1. Apontar (seleção simples de objeto - sem colisão direta)
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Apenas o marcador do indicador
    public class IndexFingerTip : MonoBehaviour
    {
        //Ativação ou Desativação do gesto, para checar
        private bool _isActive;
        public ref bool IsActive
        {
            get { return ref this._isActive; }
        }

        ObserverBehaviour imageTargetBehaviour;

        //Esfera do marcador
        private GameObject _sphere;
        public GameObject Sphere
        {
            get { return this._sphere; }
            set { this._sphere = value; }
        }

        public IndexFingerTip()
        {
            this._isActive = false;
        }

        private void Awake() 
        {
            imageTargetBehaviour = gameObject.GetComponent<ObserverBehaviour>();
            _sphere = gameObject.transform.GetChild(0).gameObject;
        }

        private void Start() 
        {
            if (imageTargetBehaviour)
            {
                imageTargetBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
            }
        }

        private void OnTargetStatusChanged(ObserverBehaviour observerbehavour, TargetStatus status)
        {
            if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED ||
                status.StatusInfo == StatusInfo.NORMAL)
            {
                Debug.Log("O 'Indicador' está sendo rastreado. Nome: " + observerbehavour.TargetName);
                this._isActive = true;
            }
            else
            {

                Debug.Log("O 'Indicador' foi perdido. Nome: " + observerbehavour.TargetName);
                this._isActive = false;
            }
        }

        private void OnDestroy()
        {
            imageTargetBehaviour.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}