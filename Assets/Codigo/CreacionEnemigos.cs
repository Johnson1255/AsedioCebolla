using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreacionEnemigos : MonoBehaviour
{
    [Header("Referencias")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Atributos")]
    [SerializeField] private int EnemigosBase = 8;
    [SerializeField] private int EnemigosPorSegundo = 0.5f;
    [SerializeField] private float TiempoEntreOleadas = 5f;
    [SerializeField] private float DificultadEnemigos = 0.75f;

    private int OleadaActual = 1;
    private float TiempoUltimoSpawneado;
    private int EnemigosVivos;
    private int EnemigosFaltaSpawnear;
    void Start()
    {
        EnemigosFaltaSpawnear = EnemigosBase;
    }

    void Update()
    {
        
    }
}
