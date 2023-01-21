using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace Experiments
{
    [System.Serializable]
    public class ExperimentsMetrics
    {
        /// <summary>
        ///   Tipo de Experimento: 01 ou 02
        /// </summary>
        public String experimentName;

        /// <summary>
        ///   Número Atual do Cenário de Cada Experimento
        /// </summary>
        public int actualTestScene;

        /// <summary>
        ///   Contador de ciclo de execução
        /// </summary>
        public int cycleCount;

        /// <summary>
        ///   Contador de execução do cenário proposto
        /// </summary>
        public int executionCount;

        /// <summary>
        ///   Tempo inicial decorrido para reconhecer qualquer gestos
        /// </summary>
        public float timeRecognition;

        /// <summary>
        ///   Distânica da mão a um objeto selecionado: pinça fechada (Exp01) e apontar (Exp02)
        /// </summary>
        public float distanceObject;

        /// <summary>
        ///   Tempo decorrido para terminar um teste de uma cena
        /// </summary>
        public float timeScene;

        /// <summary>
        ///   Distância entre: centro de objeto e seu respectivo alvo (Exp01) ou centro do indicador e centro do alvo (Exp02)
        /// </summary>
        public float distanceError;

        /// <summary>
        ///   Quantidade de erros: objeto no alvo incorreto (Exp01) ou objeto indicado incorreto (Exp02)
        /// </summary>
        public float targetError;

        /// <summary>
        ///   Quantidade do gesto "APONTAR" realizado pelo usuário em um teste
        /// </summary>
        public int countApontar; //Apontar

        /// <summary>
        ///   Quantidade do gesto "PINÇA FECHADA" realizado pelo usuário em um teste
        /// </summary>
        public int countPincaFechada; //Pinça Fechada

        /// <summary>
        ///   Quantidade do gesto "PINÇA FECHADA E MOVER" realizado pelo usuário em um teste
        /// </summary>
        public int countPincaFechadaMover; //Pinça Fechada e Mover

        /// <summary>
        ///   Quantidade do gesto "PINÇA ABERTA" realizado pelo usuário em um teste
        /// </summary>
        public int countPincaAberta; //Pinça Aberta
    }
    public class ExperimentMetricsManager
    {
        //Nome do arquivo JSON
        private string _fileName;
        private string _extension = ".json";

        //Salvar os dados dos experimentos
        public void SaveData(in ExperimentsMetrics resultsObtained)
        {
            _fileName = resultsObtained.experimentName + "_Cenario" + resultsObtained.actualTestScene + _extension;
            string json = JsonUtility.ToJson(resultsObtained);
            WriteToFile(ref json);
        }

        //Escrever o JSON em um arquivo
        private void WriteToFile(ref string json)
        {
            //Salvando o caminho do arquivo
            string path = Application.persistentDataPath + "/" + _fileName;

            //Verificando se o arquivo existe
            if (File.Exists(path))
            {
                string fileContents = File.ReadAllText(path);
                json = (fileContents + "," + json);
            }

            //Cria/Substitui o arquivo e inicia o modo escrita
            File.WriteAllText(path, json);
        }

    }
}

