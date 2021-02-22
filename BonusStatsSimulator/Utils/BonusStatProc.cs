using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BonusStatsSimulator.Models;

namespace BonusStatsSimulator.Utils
{
    public static class BonusStatProc
    {
        private static readonly ReadOnlyDictionary<string, ReadOnlyCollection<int>> BonusStat140;

        private static readonly ReadOnlyDictionary<string, ReadOnlyCollection<int>> BonusStat150;

        private static readonly ReadOnlyDictionary<string, ReadOnlyCollection<int>> BonusStat160;

        private static readonly ReadOnlyDictionary<string, ReadOnlyCollection<int>> BonusStat200;

        private static readonly ReadOnlyDictionary<string, ReadOnlyCollection<int>> BonusStatProb;

        static BonusStatProc()
        {
            BonusStat140 = new ReadOnlyDictionary<string, ReadOnlyCollection<int>>(new Dictionary<string, ReadOnlyCollection<int>>
            {
                {"Str", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Dex", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Int", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Luk", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"StrDex", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"StrInt", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"StrLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"DexInt", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"DexLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"IntLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"Hp", new ReadOnlyCollection<int>(new List<int>{1260, 1680, 2100, 2520, 2940}) },
                {"Mp", new ReadOnlyCollection<int>(new List<int>{1260, 1680, 2100, 2520, 2940}) },
                {"All", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Atk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Mtk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Spd", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Jmp", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Def", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"ReqLev", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) }
            });

            BonusStat150 = new ReadOnlyDictionary<string, ReadOnlyCollection<int>>(new Dictionary<string, ReadOnlyCollection<int>>
            {
                {"Str", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Dex", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Int", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"Luk", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"StrDex", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"StrInt", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"StrLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"DexInt", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"DexLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"IntLuk", new ReadOnlyCollection<int>(new List<int>{12, 16, 20, 24, 28}) },
                {"Hp", new ReadOnlyCollection<int>(new List<int>{1350, 1800, 2250, 2700, 3150}) },
                {"Mp", new ReadOnlyCollection<int>(new List<int>{1350, 1800, 2250, 2700, 3150}) },
                {"All", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Atk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Mtk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Spd", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Jmp", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Def", new ReadOnlyCollection<int>(new List<int>{24, 32, 40, 48, 56}) },
                {"ReqLev", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) }
            });

            BonusStat160 = new ReadOnlyDictionary<string, ReadOnlyCollection<int>>(new Dictionary<string, ReadOnlyCollection<int>>
            {
                {"Str", new ReadOnlyCollection<int>(new List<int>{27, 36, 45, 54, 63}) },
                {"Dex", new ReadOnlyCollection<int>(new List<int>{27, 36, 45, 54, 63}) },
                {"Int", new ReadOnlyCollection<int>(new List<int>{27, 36, 45, 54, 63}) },
                {"Luk", new ReadOnlyCollection<int>(new List<int>{27, 36, 45, 54, 63}) },
                {"StrDex", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"StrInt", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"StrLuk", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"DexInt", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"DexLuk", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"IntLuk", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) },
                {"Hp", new ReadOnlyCollection<int>(new List<int>{1440, 1920, 2400, 2880, 3360}) },
                {"Mp", new ReadOnlyCollection<int>(new List<int>{1440, 1920, 2400, 2880, 3360}) },
                {"All", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Atk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Mtk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Spd", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Jmp", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Def", new ReadOnlyCollection<int>(new List<int>{27, 36, 45, 54, 63}) },
                {"ReqLev", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) }
            });

            BonusStat200 = new ReadOnlyDictionary<string, ReadOnlyCollection<int>>(new Dictionary<string, ReadOnlyCollection<int>>
            {
                {"Str", new ReadOnlyCollection<int>(new List<int>{33, 44, 55, 66, 77}) },
                {"Dex", new ReadOnlyCollection<int>(new List<int>{33, 44, 55, 66, 77}) },
                {"Int", new ReadOnlyCollection<int>(new List<int>{33, 44, 55, 66, 77}) },
                {"Luk", new ReadOnlyCollection<int>(new List<int>{33, 44, 55, 66, 77}) },
                {"StrDex", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"StrInt", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"StrLuk", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"DexInt", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"DexLuk", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"IntLuk", new ReadOnlyCollection<int>(new List<int>{18, 24, 30, 36, 42}) },
                {"Hp", new ReadOnlyCollection<int>(new List<int>{1800, 2400, 3000, 3600, 4200}) },
                {"Mp", new ReadOnlyCollection<int>(new List<int>{1800, 2400, 3000, 3600, 4200}) },
                {"All", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Atk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Mtk", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Spd", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Jmp", new ReadOnlyCollection<int>(new List<int>{3, 4, 5, 6, 7}) },
                {"Def", new ReadOnlyCollection<int>(new List<int>{33, 44, 55, 66, 77}) },
                {"ReqLev", new ReadOnlyCollection<int>(new List<int>{15, 20, 25, 30, 35}) }
            });

            BonusStatProb = new ReadOnlyDictionary<string, ReadOnlyCollection<int>>(new Dictionary<string, ReadOnlyCollection<int>>
            {
                {"Drop", new ReadOnlyCollection<int>(new List<int>{25, 30, 30, 14, 1}) },   // 아이템 드랍
                {"SPhx", new ReadOnlyCollection<int>(new List<int>{20, 30, 36, 14, 0}) },   // 강력한 환생의 불꽃
                {"FPhx", new ReadOnlyCollection<int>(new List<int>{0, 29, 45, 25, 1}) },    // 영원한 환생의 불꽃
                {"Normal", new ReadOnlyCollection<int>(new List<int>{50, 40, 10, 0, 0}) },  // 일반 제작/합성
                {"MPrd", new ReadOnlyCollection<int>(new List<int>{15, 30, 40, 14, 1}) },   // 장인 제작
                {"APrd", new ReadOnlyCollection<int>(new List<int>{0, 19, 50, 30, 1}) },    // 명장 제작
                {"MCmp", new ReadOnlyCollection<int>(new List<int>{25, 35, 30, 10, 0}) },   // 장인 합성
                {"ACmp", new ReadOnlyCollection<int>(new List<int>{0, 40, 45, 14, 1}) },    // 명장 합성
                {"Chance", new ReadOnlyCollection<int>(new List<int>{0, 30, 50, 19, 1}) }   // 조각 찬스타임
            });
        }

        public static BonusStat GetRandomOptions(int level, string type)
        {
            var rand = new Random();
            var randIndex = new List<int>();
            var result = new BonusStat();
            ReadOnlyDictionary<string, ReadOnlyCollection<int>> statTable;

            // Select stat table.
            switch (level)
            {
                case 140:
                    statTable = BonusStat140;
                    break;
                case 150:
                    statTable = BonusStat150;
                    break;
                case 160:
                    statTable = BonusStat160;
                    break;
                case 200:
                    statTable = BonusStat200;
                    break;
                default:
                    return null;
            }

            // Select options.
            for (;;)
            {
                var temp = rand.Next(0, 18);
                if (!randIndex.Contains(temp))
                    randIndex.Add(temp);

                if (randIndex.Count >= 4)
                    break;
            }

            // Select grade for each options.
            foreach (var i in randIndex)
            {
                var grade = GetRandomGrade(type);
                result.AddStat(i, statTable[GetDictionaryKey(i)][grade]);
            }
            
            return result;
        }

        private static int GetRandomGrade(string type)
        {
            var probList = BonusStatProb[GetProbDictionaryKey(type)];
            var rand = new Random();
            var sum = 0;

            var randValue = rand.Next(1, 100);
            for(var i = 0; i < probList.Count; i++)
            {
                if (randValue.Inside(sum, sum + probList[i]))
                    return i;

                sum += probList[i];
            }

            return -1;
        }

        private static string GetDictionaryKey(int index)
        {
            var indexList = new List<string>
            {
                "Str", "Dex", "Int", "Luk", "StrDex", "StrInt", "StrLuk", "DexInt", "DexLuk", "IntLuk", "Hp", "Mp",
                "All", "Atk", "Mtk", "Spd", "Jmp", "Def", "ReqLev"
            };

            return indexList[index];
        }

        private static string GetProbDictionaryKey(string type)
        {
            if (type == "아이템 드랍")
                return "Drop";
            if (type == "강력한 환생의 불꽃")
                return "SPhx";
            if (type == "영원한 환생의 불꽃")
                return "FPhx";
            if (type == "일반 제작/합성")
                return "Normal";
            if (type == "장인 제작")
                return "MPrd";
            if (type == "명장 제작")
                return "APrd";
            if (type == "장인 합성")
                return "MCmp";
            if (type == "명장 합성")
                return "ACmp";
            if (type == "찬스타임")
                return "Chance";
            return null;
        }
    }
}
