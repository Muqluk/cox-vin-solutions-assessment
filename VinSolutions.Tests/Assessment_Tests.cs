namespace VinSolutions.Tests {
  [TestClass]
  public class Assessment_Tests {

    const string sentence1 = "Smooth";
    const string sentence2 = "Space separated";
    const string sentence3 = "Dash-separated";
    const string sentence4 = "Number2separated";

    const string expected1 = "S3h";
    const string expected2 = "S3e s5d";
    const string expected3 = "D2h-s5d";
    const string expected4 = "N4r2s5d";



    #region Sanity Checks

    [TestMethod]
    public void ParseSentence_returns_string_result() {
      Assert.IsTrue(Assessment.ParseSentence(String.Empty) == String.Empty);
    }

    #endregion

    #region Integration Tests

    [TestMethod]
    public void ParseSentence_example_1_succeeds() {
      var result = Assessment.ParseSentence(sentence1);

      Assert.IsTrue(result == expected1);
    }

    //[Ignore]
    [TestMethod]
    public void ParseSentence_example_2_succeeds() {
      var result = Assessment.ParseSentence(sentence2);
      Assert.IsTrue(result == expected2);
    }

    //[Ignore]
    [TestMethod]
    public void ParseSentence_example_3_succeeds() {
      var result = Assessment.ParseSentence(sentence3);
      Assert.IsTrue(result == expected3);
    }

    //[Ignore]
    [TestMethod]
    public void ParseSentence_example_4_succeeds() {
      var result = Assessment.ParseSentence(sentence4);
      Assert.IsTrue(result == expected4);
    }

    #endregion
  }
}
