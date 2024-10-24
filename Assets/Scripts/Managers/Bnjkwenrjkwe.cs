using System;
using System.Linq;
using Content;
using Entities;
using UnityEngine;

namespace Managers
{
    public class Bnjkwenrjkwe
    {
        private const string PassedLevelsKey = "PassedLevels";
        private const string ScoreKey = "ScoreKey";
        private const string BoughtShipsKey = "BoughtShips";
        private const string SelectedShipKey = "SelectedShip";
        private const string LevelResultsKey = "LevelResult";
        
        private readonly Nnvjkernkjq _nnvjkernkjq;

        public int PassedLevels => PlayerPrefs.GetInt(PassedLevelsKey);
        public int LevelsCount => _nnvjkernkjq.VNnjkwenkrq.Length;

        public int Score
        {
            get => PlayerPrefs.GetInt(ScoreKey);
            set => PlayerPrefs.SetInt(ScoreKey, value);
        }

        public int[] BoughtShips
        {
            get => PlayerPrefs.GetString(BoughtShipsKey)
                .Split(',')
                .Select(c => Convert.ToInt32(c))
                .ToArray();
            set => PlayerPrefs.SetString(BoughtShipsKey, String.Join(",", value));
        }

        public int SelectedShip
        {
            get => PlayerPrefs.GetInt(SelectedShipKey);
            set => PlayerPrefs.SetInt(SelectedShipKey, value);
        }

        public int[] LevelResults
        {
            get => PlayerPrefs.GetString(LevelResultsKey)
                .Split(',')
                .Select(c => Convert.ToInt32(c))
                .ToArray();
            set => PlayerPrefs.SetString(LevelResultsKey, String.Join(",", value));
        }

        public int LastLevelIndex => PlayerPrefs.GetInt(PassedLevelsKey) < _nnvjkernkjq.VNnjkwenkrq.Length
            ? PlayerPrefs.GetInt(PassedLevelsKey)
            : _nnvjkernkjq.VNnjkwenkrq.Length - 1;
            
        
        public Bnjkwenrjkwe(Nnvjkernkjq nnvjkernkjq)
        {
            _nnvjkernkjq = nnvjkernkjq;

            if (!PlayerPrefs.HasKey(PassedLevelsKey))
            {
                PlayerPrefs.SetInt(PassedLevelsKey, 0);
            }

            if (!PlayerPrefs.HasKey(ScoreKey))
            {
                PlayerPrefs.SetInt(ScoreKey, 0);
            }

            if (!PlayerPrefs.HasKey(BoughtShipsKey))
            {
                PlayerPrefs.SetString(BoughtShipsKey, "0");
                PlayerPrefs.SetInt(SelectedShipKey, 0);
            }

            if (!PlayerPrefs.HasKey(LevelResultsKey))
            {
                PlayerPrefs.SetString(
                    LevelResultsKey,
                    String.Join(",", new int[28])
                );
            }
        }

        public Bnjkewnrfjwebvhjrt GetLevelData(int index) =>
            _nnvjkernkjq.VNnjkwenkrq[index];

        public void IncreasePassedLevels(int currentLevel)
        {
            if (currentLevel == PassedLevels)
                PlayerPrefs.SetInt(PassedLevelsKey, PassedLevels + 1);
        }
    }
}