using System.Threading;
using BetterChifoumi;

namespace BetterChifoumi.UnitTests
{
    [TestClass]
    public class ChifoumiTest
    {
        [TestMethod]
        [DataRow(1, Moove.rock)]
        [DataRow(2, Moove.paper)]
        [DataRow(3, Moove.scissors)]
        [DataRow(4, Moove.lizard)]
        [DataRow(5, Moove.spock)]
        public void GetPlayerMove_Numbers_returnMoove(int input, Moove expectedResult)
        {
            var playerMoove = Chifoumi.GetPlayerMove(input);
            Assert.AreEqual(expectedResult, playerMoove);
        }

        [TestMethod]
        [DataRow(0, Moove.rock)]
        [DataRow(6, Moove.paper)]
        [DataRow(9, Moove.scissors)]
        public void GetPlayerMove_Numbers_returnMessageError(int input, Moove expectedResult)
        {
            var playerMoove = Chifoumi.GetPlayerMove(input);
            Assert.AreEqual(expectedResult, playerMoove);
        }

        [TestMethod]
        public void GetAiMove_Numbers_returnMoove()
        {
            var aiMove = Chifoumi.GetAIMove();
            Assert.IsTrue(aiMove >= Moove.rock && aiMove <= Moove.spock);
        }

        [TestMethod]
        [DataRow(Moove.rock, Moove.scissors, "Vous gagnez !")]
        [DataRow(Moove.paper, Moove.rock, "Vous gagnez !")]
        [DataRow(Moove.scissors, Moove.paper, "Vous gagnez !")]
        [DataRow(Moove.lizard, Moove.paper, "Vous gagnez !")]
        [DataRow(Moove.spock, Moove.scissors, "Vous gagnez !")]
        [DataRow(Moove.rock, Moove.paper, "L'IA gagne !")]
        [DataRow(Moove.paper, Moove.scissors, "L'IA gagne !")]
        [DataRow(Moove.scissors, Moove.rock, "L'IA gagne !")]
        [DataRow(Moove.lizard, Moove.rock, "L'IA gagne !")]
        [DataRow(Moove.spock, Moove.paper, "L'IA gagne !")]
        [DataRow(Moove.rock, Moove.rock, "Égalité !")]
        [DataRow(Moove.paper, Moove.paper, "Égalité !")]
        [DataRow(Moove.scissors, Moove.scissors, "Égalité !")]
        [DataRow(Moove.lizard, Moove.lizard, "Égalité !")]
        [DataRow(Moove.spock, Moove.spock, "Égalité !")]
        public void Winner_Mooves_returnString(Moove playerMove, Moove aiMove, string expectedResult)
        {
            var result = Chifoumi.Winner(playerMove, aiMove);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
