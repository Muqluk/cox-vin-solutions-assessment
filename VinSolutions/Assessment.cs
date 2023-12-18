using System.Text;

namespace VinSolutions {
  public static class Assessment {
    // In the programming language of your choice write a program that
    // parses a sentence and replaces each wird with the follow:
    //    * First letter
    //    * number of distinct characters between first and last character
    //    * last letter.
    //
    // Words are separated by spaces or non-alphapetic characters
    // and these separators should be maintained in their original
    // form and location in the answer
    //
    // Examples:
    //    1)    "Smooth"             becomes     "S3h"
    //    2)    "Space separated"    becomes     "S3e s5d"
    //    3)    "Dash-separated"     becomes     "D2h-s5d"
    //    4)    "Number2separated"   becomes     "N4r2s5d"
    //
    // We will be looking for accuracy, efficiency, and solution completeness.
    // Please include this problem description in a comment at the top of your
    // solution.  The problem is designed to take about 1-2 hours and will be
    // used as a conversation point in the verbal assessment part of your interview.
    // 
    // Please complete the coding assessment as soon as possible and upload it
    // to a public repository in GitHub or another source control provider.
    //
    // Send a link to your repository prior to your interview.

    /*
      CHAR / ASCII
      65-90     - uCase alpha
      97-122    - lCase alpha
          -- all else are 'separators'
    */

    public static string ParseSentence(string sentence = "") {
      var length = sentence.Length;
      var chars = sentence.ToCharArray();
      var distincts = new HashSet<char>();
      var newWord = false;
      var result = new StringBuilder();



      for (int i = 0; i < length; i++) {
        var chr = chars[i];

        if (i == 0 || newWord) {
          // add first charecter as-is (I do question what should occur if first char is '1' or '$' or etc
          result.Append(chr);
          newWord = false;
        } else if (i == length - 1) { // last charecter
          // wrap up any temps and add them then...
          result.Append(distincts.Count());
          // finally, add the last charecter
          result.Append(chr);
        } else { // we're in the middle
          if (char.IsLetter(chr)) { // current chr is a letter
            // not last char in chars array and next chr is a seperator char
            if (i < length - 1 && char.IsLetter(chars[i + 1]) == false) {        
              // wrap up distincts
              result.Append(distincts.Count());
              distincts.Clear();
              // then append chr
              result.Append(chr);
            } else { // we're in the middle and we're not a seperator, nor is one next
              // update distincts

              distincts.Add(chr);
            }
          } else { // chr is not a letter (is a separator)
            // append chr as-is.
            result.Append(chr);
            newWord = true;
          }
        }
      }

      return result.ToString();
    }

  }
}
