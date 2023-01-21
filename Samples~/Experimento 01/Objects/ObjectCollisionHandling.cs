using System.Collections;
using System.Collections.Generic;
using GR;
using UnityEngine;
using Vuforia;

namespace Experiments.Exp01
{
    class ObjectCollisionHandling : MonoBehaviour
    {
        //! Importação do Reconhecedor de Gestos
        GestureRecognition gestureRecognition;

        Experimento01 experimento01;
        Transform _parentTransform;
        ObserverBehaviour _indexObserverBehaviour;

        private void Awake()
        {
            gestureRecognition = GameObject.Find("Gesture Recognition").GetComponent<GestureRecognition>();
            experimento01 = this.gameObject.GetComponentInParent<Experimento01>();
            _parentTransform = this.gameObject.transform.parent;
            _indexObserverBehaviour = GameObject.Find("M_Index_Finger_Tip").GetComponent<ObserverBehaviour>();
        }

        //!Se não estiver tendo colisão alguma, realizar a "falsa colisão" por meio de corotina de verificação de distância

        void OnCollisionEnter(Collision collisionInfo)
        {
            grabObject(collisionInfo);
        }

        void OnCollisionStay(Collision collisionInfo)
        {
            grabObject(collisionInfo);
        }

        void grabObject(in Collision collisionInfo)
        {
            //Somente verifica colisão se estiver com gesto de pinça fechada ativo
            if (gestureRecognition.activeGesture == GestureType.TweezersClose
                || gestureRecognition.activeGesture == GestureType.TweezersCloseAndMove)
            {
                //Colisão com o polegar
                if (collisionInfo.gameObject.name == "ThumbTip_Sphere")
                {
                    experimento01.thumbCollisionInfo.text = this.gameObject.name + " colidiu com o Polegar";
                    Debug.Log("OCH - Colisão com Polegar");
                }

                //Colisão com o indicador
                if (collisionInfo.gameObject.name == "Index_Finger_Tip_Sphere")
                {
                    experimento01.indexCollisionInfo.text = this.gameObject.name + " colidiu com o Indicador";
                    Debug.Log("OCH - Colisão com Indicador");
                }

                //Não permite força da gravidade
                this.gameObject.GetComponent<Rigidbody>().useGravity = false;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;

                //Fazendo o objeto seguir a movimentação da pinça: Posição do Indicador (tornar filho)
                this.transform.SetParent(_indexObserverBehaviour.transform);
                //this.transform.position = _indexObserverBehaviour.transform.position;
                this.transform.LookAt(_indexObserverBehaviour.transform);
            }
        }

        void OnCollisionExit(Collision collisionInfo)
        {
            //Somente verifica colisão se estiver com gesto de pinça aberta ativo
            if (gestureRecognition.activeGesture == GestureType.TweezersOpen)
            {
                //Colisão com o polegar
                if (collisionInfo.gameObject.name == "ThumbTip_Sphere")
                {
                    experimento01.thumbCollisionInfo.text = this.gameObject.name + " deixou de colidir com o Polegar";
                    Debug.Log("OCH - Terminou Colisão com Polegar");
                }

                //Colisão com o indicador
                if (collisionInfo.gameObject.name == "Index_Finger_Tip_Sphere")
                {
                    experimento01.indexCollisionInfo.text = this.gameObject.name + " deixou de colidir com o Indicador";
                    Debug.Log("OCH - Terminou Colisão com Indicador");
                }

                //Fazendo o objeto cair: Acionando a gravidade e tirar filho
                this.transform.SetParent(_parentTransform);
                //StartCoroutine(fallingObject());
                this.gameObject.GetComponent<Rigidbody>().useGravity = true;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
                this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
                this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 100f);
            }

        }

        IEnumerator fallingObject()
        {
            while (this.transform.localPosition.y > 2.0f)
            {
                float fallSpeed = 3.0f;
                yield return new WaitForFixedUpdate();
                this.transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
            }
        }

        void OnTriggerEnter(Collider other)
        {
            //Colisão com o polegar
            if (other.gameObject.name == "ThumbTip_Sphere")
            {
                Debug.Log("OCH - Trigger1 Colisão com Polegar");
            }

            //Colisão com o indicador
            if (other.gameObject.name == "Index_Finger_Tip_Sphere")
            {
                Debug.Log("OCH - Trigger1 Colisão com Indicador");
            }
        }

        void OnTriggerStay(Collider other)
        {
            //Colisão com o polegar
            if (other.gameObject.name == "ThumbTip_Sphere")
            {
                Debug.Log("OCH - Trigger2 Colisão com Polegar");
            }

            //Colisão com o indicador
            if (other.gameObject.name == "Index_Finger_Tip_Sphere")
            {
                Debug.Log("OCH - Trigger2 Colisão com Indicador");
            }
        }

        void OnTriggerExit(Collider other)
        {
            //Colisão com o polegar
            if (other.gameObject.name == "ThumbTip_Sphere")
            {
                Debug.Log("OCH - Trigger3 Colisão com Polegar");
            }

            //Colisão com o indicador
            if (other.gameObject.name == "Index_Finger_Tip_Sphere")
            {
                Debug.Log("OCH - Trigger3 Colisão com Indicador");
            }
        }
    }
}