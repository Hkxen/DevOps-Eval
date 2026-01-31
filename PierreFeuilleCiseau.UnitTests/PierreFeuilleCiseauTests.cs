namespace PierreFeuilleCiseauProject.UnitTests
{
    [TestClass]
    public sealed class PierreFeuilleCiseauTests
    {
        private PierreFeuilleCiseau _PierreFeuilleCiseau;

        [TestInitialize]
        public void Init()
        {
            _PierreFeuilleCiseau = new PierreFeuilleCiseau();
        }

        [TestMethod]
        public void Check_BotsPick_ShouldReturnStringChoice()
        {
            var result = _PierreFeuilleCiseau.BotsPick();
            Assert.IsTrue(_PierreFeuilleCiseau.choices.Contains(result));
        }

        [TestMethod]
        [DataRow("Ciseau", "Feuille", "Vous avez gagné !")]
        [DataRow("Ciseau", "Lézard", "Vous avez gagné !")]
        [DataRow("Pierre", "Ciseau", "Vous avez gagné !")]
        [DataRow("Pierre", "Lézard", "Vous avez gagné !")]
        [DataRow("Feuille", "Pierre", "Vous avez gagné !")]
        [DataRow("Feuille", "Spock", "Vous avez gagné !")]
        [DataRow("Lézard", "Spock", "Vous avez gagné !")]
        [DataRow("Lézard", "Feuille", "Vous avez gagné !")]
        [DataRow("Spock", "Ciseau", "Vous avez gagné !")]
        [DataRow("Spock", "Pierre", "Vous avez gagné !")]
        public void Check_CheckIfPlayerWon_ShouldReturnVictoryString(string playersChoice, string botsChoice, string expectedResult)
        {
            var result = _PierreFeuilleCiseau.CheckIfPlayerWon(playersChoice, botsChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Ciseau", "Pierre", "Vous avez perdu !")]
        [DataRow("Ciseau", "Spock", "Vous avez perdu !")]
        [DataRow("Pierre", "Feuille", "Vous avez perdu !")]
        [DataRow("Pierre", "Spock", "Vous avez perdu !")]
        [DataRow("Feuille", "Ciseau", "Vous avez perdu !")]
        [DataRow("Feuille", "Lézard", "Vous avez perdu !")]
        [DataRow("Lézard", "Pierre", "Vous avez perdu !")]
        [DataRow("Lézard", "Ciseau", "Vous avez perdu !")]
        [DataRow("Spock", "Feuille", "Vous avez perdu !")]
        [DataRow("Spock", "Lézard", "Vous avez perdu !")]
        public void Check_CheckIfPlayerWon_ShouldReturnLossString(string playersChoice, string botsChoice, string expectedResult)
        {
            var result = _PierreFeuilleCiseau.CheckIfPlayerWon(playersChoice, botsChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Pierre", true)]
        [DataRow("Feuille", true)]
        [DataRow("Ciseau", true)]
        [DataRow("Lézard", true)]
        [DataRow("Spock", true)]
        public void Check_IsTheChoiceValid_ShouldReturnTrue(string playersChoice, bool expectedResult)
        {
            var result = _PierreFeuilleCiseau.IsTheChoiceValid(playersChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Pizza", false)]
        [DataRow("Spaghetti", false)]
        [DataRow("Pomme", false)]
        [DataRow("Italie", false)]
        [DataRow("France", false)]
        public void Check_IsTheChoiceValid_ShouldReturnFalse(string playersChoice, bool expectedResult)
        {
            var result = _PierreFeuilleCiseau.IsTheChoiceValid(playersChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Ciseau", "Feuille", "Ciseau (vous) vs Feuille (bot), Vous avez gagné !")]
        [DataRow("Ciseau", "Lézard", "Ciseau (vous) vs Lézard (bot), Vous avez gagné !")]
        [DataRow("Pierre", "Ciseau", "Pierre (vous) vs Ciseau (bot), Vous avez gagné !")]
        [DataRow("Pierre", "Lézard", "Pierre (vous) vs Lézard (bot), Vous avez gagné !")]
        [DataRow("Feuille", "Pierre", "Feuille (vous) vs Pierre (bot), Vous avez gagné !")]
        [DataRow("Feuille", "Spock", "Feuille (vous) vs Spock (bot), Vous avez gagné !")]
        [DataRow("Lézard", "Spock", "Lézard (vous) vs Spock (bot), Vous avez gagné !")]
        [DataRow("Lézard", "Feuille", "Lézard (vous) vs Feuille (bot), Vous avez gagné !")]
        [DataRow("Spock", "Ciseau", "Spock (vous) vs Ciseau (bot), Vous avez gagné !")]
        [DataRow("Spock", "Pierre", "Spock (vous) vs Pierre (bot), Vous avez gagné !")]
        public void Check_PlayTheGame_ShouldReturnVictoryString(string playersChoice, string botsChoice, string expectedResult)
        {
            var result = _PierreFeuilleCiseau.PlayTheGame(playersChoice, botsChoice);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        [DataRow("Ciseau", "Pierre", "Ciseau (vous) vs Pierre (bot), Vous avez perdu !")]
        [DataRow("Ciseau", "Spock", "Ciseau (vous) vs Spock (bot), Vous avez perdu !")]
        [DataRow("Pierre", "Feuille", "Pierre (vous) vs Feuille (bot), Vous avez perdu !")]
        [DataRow("Pierre", "Spock", "Pierre (vous) vs Spock (bot), Vous avez perdu !")]
        [DataRow("Feuille", "Ciseau", "Feuille (vous) vs Ciseau (bot), Vous avez perdu !")]
        [DataRow("Feuille", "Lézard", "Feuille (vous) vs Lézard (bot), Vous avez perdu !")]
        [DataRow("Lézard", "Pierre", "Lézard (vous) vs Pierre (bot), Vous avez perdu !")]
        [DataRow("Lézard", "Ciseau", "Lézard (vous) vs Ciseau (bot), Vous avez perdu !")]
        [DataRow("Spock", "Feuille", "Spock (vous) vs Feuille (bot), Vous avez perdu !")]
        [DataRow("Spock", "Lézard", "Spock (vous) vs Lézard (bot), Vous avez perdu !")]
        public void Check_PlayTheGame_ShouldReturnLossString(string playersChoice, string botsChoice, string expectedResult)
        {
            var result = _PierreFeuilleCiseau.PlayTheGame(playersChoice, botsChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow("Pierre", "Pierre", "Pierre (vous) vs Pierre (bot), Egalité !")]
        [DataRow("Ciseau", "Ciseau", "Ciseau (vous) vs Ciseau (bot), Egalité !")]
        [DataRow("Feuille", "Feuille", "Feuille (vous) vs Feuille (bot), Egalité !")]
        [DataRow("Lézard", "Lézard", "Lézard (vous) vs Lézard (bot), Egalité !")]
        [DataRow("Spock", "Spock", "Spock (vous) vs Spock (bot), Egalité !")]
        public void Check_PlayTheGame_ShouldReturnDrawString(string playersChoice, string botsChoice, string expectedResult)
        {
            var result = _PierreFeuilleCiseau.PlayTheGame(playersChoice, botsChoice);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PlayTheGame_WithWrongChoice_ShouldThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => _PierreFeuilleCiseau.PlayTheGame("Pizza", "Ciseau"));
        }
    }
}
