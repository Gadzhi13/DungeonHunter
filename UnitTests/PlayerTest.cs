using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DungeonHunterBusinessLogic;
using Moq;

namespace UnitTests
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void GetCurrentPosition_Returns_10_10_AfterFirstInit()
        {
            Player player = Player.GetInstance();

            int[] curPos = new int[2];
            int[] curPosTest = new int[2] { 10, 10 };

            curPos = player.GetCurrentPosition();

            Assert.AreEqual(curPosTest, curPos);
        }

        [Test]
        public void GetCurrentPosition_Returns_10_9_AfterFirstInitAndMoveUp()
        {
            Player player = Player.GetInstance();

            player.MoveUp();

            int[] curPos = new int[2];
            int[] curPosTest = new int[2] { 10, 9 };

            curPos = player.GetCurrentPosition();

            Assert.AreEqual(curPosTest, curPos);
        }

        [Test]
        public void GetCurrentPosition_Returns_10_11_AfterFirstInitAndMoveDown()
        {
            Player player = Player.GetInstance();

            player.MoveDown();

            int[] curPos = new int[2];
            int[] curPosTest = new int[2] { 10, 11 };

            curPos = player.GetCurrentPosition();

            Assert.AreEqual(curPosTest, curPos);
        }

        [Test]
        public void GetCurrentPosition_Returns_9_10_AfterFirstInitAndMoveLeft()
        {
            Player player = Player.GetInstance();

            player.MoveLeft();

            int[] curPos = new int[2];
            int[] curPosTest = new int[2] { 9, 10 };

            curPos = player.GetCurrentPosition();

            Assert.AreEqual(curPosTest, curPos);
        }

        [Test]
        public void GetCurrentPosition_Returns_11_10_AfterFirstInitAndMoveRight()
        {
            Player player = Player.GetInstance();

            player.MoveRight();

            int[] curPos = new int[2];
            int[] curPosTest = new int[2] { 11, 10 };

            curPos = player.GetCurrentPosition();

            Assert.AreEqual(curPosTest, curPos);
        }

        [Test]
        public void GetHealth_Returns24_AfterFirstInit()
        {
            Player player = Player.GetInstance();

            int curHealth;

            curHealth = player.GetHealth();

            Assert.AreEqual(24, curHealth);
        }

        [Test]
        public void MapCheckTileFree_IsCalled_AfterEachPlayerMove()
        {
            Mock<IMap> mockMap = new Mock<IMap>();
            Player player = Player.GetInstance();

            player.MoveDown();
            player.MoveLeft();
            player.MoveRight();
            player.MoveUp();

            mockMap.Verify(t => t.CheckTileFree(It.IsAny<int>(), It.IsAny<int>()), Times.AtLeastOnce());
        }

    }
}