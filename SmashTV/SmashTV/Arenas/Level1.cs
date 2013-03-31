﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using MesserSmash.Modules;
using MesserSmash.Commands;

namespace MesserSmash.Arenas {
    public class Level1 : Arena {
        private float _timestampLastSpawnedWave;
        //private float _internalWaveTimer;
        //private int _spawnCounter;
        private List<WaveSpawner> _spawners = new List<WaveSpawner>();
        public Level1() {
            _secondsLeft = 60;

            for (int i = 0; i < 20; i++) {
                var wave = new WaveSpawner(0, 13 + i);
                var criteria = new SpawnCriteria();
                criteria.MinSecondsInArena = i * 3;
                wave.addCriteria(criteria);
                _spawners.Add(wave);
            }
        }

        protected override List<Spawnpoint> createSpawnpoints() {            
            var list = new List<Spawnpoint>();
            list.Add(new Spawnpoint(new Rectangle(Bounds.Center.X - 140, Bounds.Bottom - 60, 60, 60),
                                    TextureManager.getArenaTexture()));
            list.Add(new Spawnpoint(new Rectangle(Bounds.Center.X + 100, Bounds.Top, 60, 60),
                                    TextureManager.getArenaTexture()));
            list.Add(new Spawnpoint(new Rectangle(Bounds.Left, Bounds.Center.Y, 60, 60),
                                    TextureManager.getArenaTexture()));
            list.Add(new Spawnpoint(new Rectangle(Bounds.Right - 60, Bounds.Center.Y, 60, 60),
                                    TextureManager.getArenaTexture()));
            return list;
        }

        public override void startLevel() {
            EventHandler.Instance.dispatchEvent(GameEvent.GameEvents.GameStarted, this, "Level 1");
            _timestampLastSpawnedWave = DataDefines.ID_LEVEL1_TIME_BETWEEN_WAVES > 1 ? DataDefines.ID_LEVEL1_TIME_BETWEEN_WAVES : 0;
        }

        protected override void custUpdate(GameState state) {
            _timestampLastSpawnedWave += state.DeltaTime;
            foreach (var wave in _spawners) {
                wave.update(state);
            }
            //if (_timestampLastSpawnedWave >= DataDefines.ID_LEVEL1_TIME_BETWEEN_WAVES) {
            //    _internalWaveTimer += gametime;
            //    if (_internalWaveTimer >= DataDefines.ID_LEVEL1_BETWEEN_EACH_UNIQUE_SPAWN_CD && _spawnCounter < DataDefines.ID_LEVEL1_MAX_ENEMIES_PER_WAVE) {
            //        getRandomSpawnpoint().generateMeleeEnemies(1);
            //        _internalWaveTimer = 0;
            //        _spawnCounter++;
            //    } else if (_spawnCounter >= DataDefines.ID_LEVEL1_MAX_ENEMIES_PER_WAVE) {
            //        _spawnCounter = 0;
            //        _internalWaveTimer = 0;
            //        _timestampLastSpawnedWave = 0;
            //    }
            //}
        }

        protected override void custSpawnWaveCommand(WaveSpawner spawner) {
            int enemyType = spawner.EnemyType;
            spawner.deactivate();
            getRandomSpawnpoint().generateMeleeEnemies(spawner.SpawnCount);
        }
    }
}
