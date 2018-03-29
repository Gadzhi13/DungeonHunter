using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DungeonHunterBusinessLogic;

namespace UnitTests
{
    [TestFixture]
    class EnemyTest
    {
        [Test]
        public void EnemyConstructor_CreatesEnemiesWithCorrectHP_AfterPassingAnId([Values(20, 30, 40, 21)] int id)
        {
            Enemy enemy = new Enemy(id);

            Assert.AreEqual(id / 2, enemy.Hp);
        }
    }
}
