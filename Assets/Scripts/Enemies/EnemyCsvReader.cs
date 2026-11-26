using NUnit.Framework;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

public static class EnemyCsvReader
{
    public static List<EnemyStats> Read(string filePath)
    {
        List<EnemyStats> enemies = new List<EnemyStats>();



        StreamReader reader = new StreamReader(filePath);

        reader.ReadLine(); // Skip the header line

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            if (string.IsNullOrWhiteSpace(line))
            {
                continue; // Skip empty lines
            }

            string[] collums = line.Split(',');

            string enemyName = collums[0].Trim();

            float health = float.Parse(collums[1].Trim(), CultureInfo.InvariantCulture);
            float speed = float.Parse(collums[2].Trim(), CultureInfo.InvariantCulture);
            float damage = float.Parse(collums[3].Trim(), CultureInfo.InvariantCulture);
            float attackDistance = float.Parse(collums[4].Trim(), CultureInfo.InvariantCulture);

            EnemyStats enemyStats = new EnemyStats(enemyName, health, speed, damage, attackDistance);
            enemies.Add(enemyStats);
        }

        return enemies;
    }

    List<EnemyStats> enemyStats = new List<EnemyStats>();

    private void Awake()
    {

        enemyStats = EnemyCsvReader.Read("Assets/Resources/EnemyStats.csv");

    }

}
