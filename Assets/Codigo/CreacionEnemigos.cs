using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionEnemigos : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Atributos")]
    [SerializeField] private int EnemigosBase = 8;
    [SerializeField] private float EnemigosPorSegundo = 0.5f;
    [SerializeField] private float TiempoEntreOleadas = 5f;
    [SerializeField] private float DificultadEnemigos = 0.75f;

    private int OleadaActual = 1;
    private float TiempoUltimoSpawneado;
    private int EnemigosVivos;
    private int EnemigosFaltaSpawnear;
    private bool EstaSpawneando = false;

    private void Start()
    {
        StartWave();
    }
    private void Update()
    {
        if (!EstaSpawneando) return;
        TiempoUltimoSpawneado += Time.deltaTime;

        if (TiempoUltimoSpawneado >= (1f / EnemigosPorSegundo))
        {
            Debug.Log("Enemigo Spawneado");
        }
    }
    void StartWave()
    {
        EstaSpawneando = true;
        EnemigosFaltaSpawnear = EnemigosPorOleada();
    }

    private int EnemigosPorOleada()
    {
        return Mathf.RoundToInt(EnemigosBase * Mathf.Pow(OleadaActual, DificultadEnemigos));
    }

}
