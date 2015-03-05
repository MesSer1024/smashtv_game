﻿using MesserSmash.Modules;
namespace MesserSmash.Arenas {
    public class Level01 : Arena {

        public Level01() {
            _secondsLeft = 60;
            Level = 1;

            for (int i = 0; i < 30; i++) {
                var wave = new WaveSpawner(0, 3 + (int)(i * 0.68f));
                var criteria = new SpawnCriteria();
                criteria.MinSecondsInArena = (int)(i * 3.74f);
                criteria.MaxEnemiesAlive = 25;
                wave.addCriteria(criteria);
                _spawners.Add(wave);
            }

            _spawners[0].SpawnCount = 6;
        }
    }
}

{"Level":1,"Time":60,"Waves":[{"EnemyType":0,"SpawnCount":6,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":0,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":3,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":3,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":4,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":7,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":5,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":11,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":5,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":14,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":6,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":18,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":7,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":22,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":7,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":26,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":8,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":29,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":9,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":33,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":9,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":37,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":10,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":41,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":11,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":44,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":11,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":48,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":12,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":52,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":13,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":56,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":13,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":59,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":14,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":63,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}},{"EnemyType":0,"SpawnCount":15,"Criteria":{"MaxEnemiesAlive":25,"MinSecondsInArena":67,"MinTotalEnemiesKilled":-1,"WaveRepeatableCount":0,"SecondsBetweenRepeat":1}}]}
