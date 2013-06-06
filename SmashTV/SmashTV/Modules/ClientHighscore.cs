﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SharedSmashResources;

namespace MesserSmash.Modules {
    class ClientHighscore {
        private static ClientHighscore _instance;
        public static ClientHighscore Instance { get {
            if (_instance == null) {
                _instance = new ClientHighscore();
            }
            return _instance;
        } }
        private ClientHighscore() {

        }

        private List<Highscore> _highscores = new List<Highscore>();

        public void resetWithTotalScoreAndInsertScoreAndOutputToFile(string name, int score, int kills) {
            string url = "./local_highscores/highscore.txt";
            load(url);
            appendScore(name, score, kills);
            overwriteFile(url);
        }

        public void resetWithLevelInsertAndOutputToFile(string name, int level, int score, int kills) {
            var url = "./local_highscores/level" + level + ".txt";
            load(url);
            appendScore(name, score, kills);
            overwriteFile(url);
        }

        private void overwriteFile(string url) {
            using (StreamWriter sw = new StreamWriter(url, false)) {
                for (int i = 0; i < _highscores.Count; ++i) {
                    var score = _highscores[i];
                    sw.WriteLine(String.Format("{0}|{1}|{2}", score.UserName, score.Score, score.Kills));
                }
            }
        }

        public void loadLocalLevelScore(int level) {
            var url = "./local_highscores/level" + level + ".txt";
            load(url);
        }

        public void load(string url = "./local_highscores/highscore.txt") {
            _highscores.Clear();

            if (new FileInfo(url).Exists) {
                using (StreamReader sr = new StreamReader(url)) {
                    while (!sr.EndOfStream) {
                        var line = sr.ReadLine().Split('|');
                        appendScore(line[0], line[1], line[2]);
                    }
                }
            }
        }

        internal void appendScore(string userName, int score, int kills) {
            _highscores.Add(new Highscore { UserName = userName, Score = (uint)score, Kills = (uint)kills });
        }

        internal void appendScore(string userName, string score, string kills) {
            _highscores.Add(new Highscore { UserName = userName, Score = uint.Parse(score), Kills = uint.Parse(kills) });
        }

        public List<Highscore> getTopScores(int howManyResults) {
            var ret = new List<Highscore>();

            var sortedHighscores = _highscores.OrderByDescending(a => a.Score);
            foreach (var item in sortedHighscores)
            {
                ret.Add(item);
                if (ret.Count >= howManyResults) {
                    return ret;
                }
            }
            return ret;
        }
    }
}
