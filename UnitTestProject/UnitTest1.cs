using NUnit.Framework;
using CSharpUnitTestSample;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestFirstName()
        {
            var person = new Person("Tamura", "Takao");

            Assert.AreEqual("Tamura", person.FirstName);
        }

        [Test]
        public void TestFirstNameEmpty()
        {
            var person = new Person("", "");

            Assert.AreEqual("Yamada", person.FirstName);
        }

        [Test]
        public void TestLastName()
        {
            var person = new Person("Tamura", "Takao");

            Assert.AreEqual("Takao", person.LastName);
        }

        [Test]
        public void TestLastNameEmpty()
        {
            var person = new Person("", "");
            
            Assert.AreEqual("Takeshi", person.LastName);
        }

        [Test]
        public void TestFullName()
        {
            var person = new Person("Tamura", "Takao");

            Assert.AreEqual("Tamura Takao", person.FullName());
        }



        // 姓が無し
        [TestCase("", "Kazuhiko", "Yamada")]
        // 姓が半角空白
        [TestCase(" ", "Kazuhiko", "Yamada")]
        // 姓が半角空白(多数)
        [TestCase("     ", "Kazuhiko", "Yamada")]
        // 姓が全角空白
        [TestCase("　", "Kazuhiko", "Yamada")]
        // 姓が全角空白(多数)
        [TestCase("　　　", "Kazuhiko", "Yamada")]
        // 姓がnull
        [TestCase(null, "Kazuhiko", "Yamada")]
        public void TestFirstNameCase(string firstName, string lastName, string expected)
        {
            var parson = new Person(firstName, lastName);

            Assert.AreEqual(expected, parson.FirstName);
        }
        
        // 名が無し
        [TestCase("Kimura", "", "Takeshi")]
        // 名が半角空白
        [TestCase("Kimura", " ", "Takeshi")]
        // 名が半角空白(多数)
        [TestCase("Kimura", "   ", "Takeshi")]
        // 名が全角空白
        [TestCase("Kimura", "　", "Takeshi")]
        // 名が全角空白(多数)
        [TestCase("Kimura", "　　　", "Takeshi")]
        // 名がnull
        [TestCase("Kimura", null, "Takeshi")]
        public void TestLastNameCase(string firstName, string lastName, string expected)
        {
            var parson = new Person(firstName, lastName);
            
            Assert.AreEqual(expected, parson.LastName);
        }

        // 姓が無し
        [TestCase("", "Kazuhiko", "Yamada Kazuhiko")]
        // 姓が半角空白
        [TestCase(" ", "Kazuhiko", "Yamada Kazuhiko")]
        // 姓が半角空白(多数)
        [TestCase("   ", "Kazuhiko", "Yamada Kazuhiko")]
        // 姓が全角空白
        [TestCase("　", "Kazuhiko", "Yamada Kazuhiko")]
        // 姓が全角空白(多数)
        [TestCase("　　　", "Kazuhiko", "Yamada Kazuhiko")]
        // 姓がnull
        [TestCase(null, "Kazuhiko", "Yamada Kazuhiko")]

        // 名が無し
        [TestCase("Kimura", "", "Kimura Takeshi")]
        // 名が半角空白
        [TestCase("Kimura", " ", "Kimura Takeshi")]
        // 名が半角空白(多数)
        [TestCase("Kimura", "    ", "Kimura Takeshi")]
        // 名が全角空白
        [TestCase("Kimura", "　", "Kimura Takeshi")]
        // 名が全角空白(多数)
        [TestCase("Kimura", "　　　", "Kimura Takeshi")]
        // 名がnull
        [TestCase("Kimura", null, "Kimura Takeshi")]
        
        // 姓と名が無し
        [TestCase("", "", "Yamada Takeshi")]
        // 姓と名が半角空白
        [TestCase(" ", " ", "Yamada Takeshi")]
        // 姓と名が半角空白(多数)
        [TestCase("    ", "   ", "Yamada Takeshi")]
        // 姓と名が全角空白
        [TestCase("　", "　", "Yamada Takeshi")]
        // 姓と名が全角空白(多数)
        [TestCase("　　　", "　　　　", "Yamada Takeshi")]
        // 姓と名がnull
        [TestCase(null, null, "Yamada Takeshi")]
        public void TestFullNameCase(string firstName, string lastName, string expected)
        {
            var parson = new Person(firstName, lastName);

            Assert.AreEqual(expected, parson.FullName());
        }
    }
}
