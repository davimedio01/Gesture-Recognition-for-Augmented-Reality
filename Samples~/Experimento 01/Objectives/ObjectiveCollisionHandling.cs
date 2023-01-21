using System.Collections;
using System.Collections.Generic;
using Experiments;
using GR;
using UnityEngine;

namespace Experiments.Exp01
{
    class ObjectiveCollisionHandling : MonoBehaviour
    {
        Experimento01 experimento01;

        const float KillObjects = 3.5f;
        const int _MinChildren = 3;

        private void Awake()
        {
            experimento01 = GameObject.Find("Experimento01").GetComponent<Experimento01>();
        }

        void OnCollisionEnter(Collision collisionInfo) { }

        void OnCollisionStay(Collision collisionInfo) { }

        void OnCollisionExit(Collision collisionInfo) { }

        void OnTriggerEnter(Collider other)
        {
            switch (this.gameObject.name)
            {
                case "CubeObjective":
                    //Caso o objeto tenha sido correto, salva o erro da distância do centro na métrica
                    if (other.gameObject.name == "Cube")
                    {
                        experimento01.metrics.distanceError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);
                        experimento01.metrics.targetError = 0.0f;
                    }
                    //Caso o objeto tenha sido incorreto, salva o erro da distância do centro na métrica
                    else if (other.gameObject.name == "Cylinder" || other.gameObject.name == "Sphere")
                    {
                        experimento01.metrics.distanceError = 0.0f;
                        experimento01.metrics.targetError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);

                    }

                    if (other.gameObject.name == "Sphere" || other.gameObject.name == "Cylinder" || other.gameObject.name == "Cube")
                    {
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);

                        //Salvar as informações obtidas no arquivo
                        experimento01.childrenCount = experimento01.transform.childCount;
                        if (experimento01.childrenCount > _MinChildren)
                        {
                            new ExperimentMetricsManager().SaveData(in experimento01.metrics);
                        }
                    }

                    break;

                case "CylinderObjective":
                    //Caso o objeto tenha sido correto, salva o erro da distância do centro na métrica
                    if (other.gameObject.name == "Cylinder")
                    {
                        experimento01.metrics.distanceError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);
                        experimento01.metrics.targetError = 0.0f;
                    }
                    //Caso o objeto tenha sido incorreto, salva o erro da distância do centro na métrica
                    else if (other.gameObject.name == "Cube" || other.gameObject.name == "Sphere")
                    {
                        experimento01.metrics.distanceError = 0.0f;
                        experimento01.metrics.targetError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);
                    }

                    if (other.gameObject.name == "Sphere" || other.gameObject.name == "Cylinder" || other.gameObject.name == "Cube")
                    {
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);

                        //Salvar as informações obtidas no arquivo
                        experimento01.childrenCount = experimento01.transform.childCount;
                        if (experimento01.childrenCount > _MinChildren)
                        {
                            new ExperimentMetricsManager().SaveData(in experimento01.metrics);
                        }
                    }

                    break;

                case "SphereObjective":
                    //Caso o objeto tenha sido correto, salva o erro da distância do centro na métrica
                    if (other.gameObject.name == "Sphere")
                    {
                        experimento01.metrics.distanceError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);
                        experimento01.metrics.targetError = 0.0f;
                    }
                    //Caso o objeto tenha sido incorreto, salva o erro da distância do centro na métrica
                    else if (other.gameObject.name == "Cylinder" || other.gameObject.name == "Cube")
                    {
                        experimento01.metrics.distanceError = 0.0f;
                        experimento01.metrics.targetError = Vector3.Distance(this.gameObject.transform.position, other.gameObject.transform.position);
                    }

                    if (other.gameObject.name == "Sphere" || other.gameObject.name == "Cylinder" || other.gameObject.name == "Cube")
                    {
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);

                        //Salvar as informações obtidas no arquivo
                        experimento01.childrenCount = experimento01.transform.childCount;
                        if (experimento01.childrenCount > _MinChildren)
                        {
                            new ExperimentMetricsManager().SaveData(in experimento01.metrics);
                        }
                    }

                    break;
            }
        }

        void OnTriggerStay(Collider other) { }

        void OnTriggerExit(Collider other) { }

    }
}