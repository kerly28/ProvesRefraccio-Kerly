using ExerciseFive;
using Xunit;

namespace TestProjectEx5
{
    public class Exercici5
    {
        //com el metodes no són estàtic em donaba error i vaig buscar como solucionar-ho i em va sortir que havia d'instanciar
        [Fact]
        public void ClassifyAgeTest1()
        {
            // Arrange
            int age = -1;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(-1, result); // Invàlid
        }

        [Fact]
        public void ClassifyAgeTest2()
        {
            // Arrange
            int age = 0;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(0, result); // Infància
        }

        [Fact]
        public void ClassifyAgeTest3()
        {
            // Arrange
            int age = 1;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(0, result); // Infància
        }

        [Fact]
        public void ClassifyAgeTest4()
        {
            // Arrange
            int age = 17;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(0, result); // Infància
        }

        [Fact]
        public void ClassifyAgeTest5()
        {
            // Arrange
            int age = 18;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(1, result); // Adulta
        }

        [Fact]
        public void ClassifyAgeTest6()
        {
            // Arrange
            int age = 65;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(1, result); // Adulta
        }

        [Fact]
        public void ClassifyAgeTest7()
        {
            // Arrange
            int age = 66;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(2, result); // Senescència
        }

        [Fact]
        public void ClassifyAgeTest8()
        {
            // Arrange
            int age = 119;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(2, result); // Senescència
        }

        [Fact]
        public void ClassifyAgeTest9()
        {
            // Arrange
            int age = 120;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(2, result); // Senescència
        }

        [Fact]
        public void ClassifyAgeTest10()
        {
            // Arrange
            int age = 121;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(-1, result); // Invàlid
        }


        [Fact]
        public void IsEvenTest()
        {
            // Arrange
            int age = 2;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            bool result = personaHelper.IsEven(age);

            // Assert
            Assert.True(result); // true, parell
        }
        [Fact]
        public void IsEvenTest1()
        {
            // Arrange
            int age = 0;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            bool result = personaHelper.IsEven(age);

            // Assert
            Assert.True(result); // True, "parell"
        }
        [Fact]
        public void IsEvenTest2()
        {
            // Arrange
            int age = 1;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            bool result = personaHelper.IsEven(age);

            // Assert
            Assert.False(result); // False, senar
        }

        [Fact]
        public void NameAnalyserTest()
        {
            // Arrange
            string name = "Anna";
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            var result = personaHelper.NameAnalyser(name);

            // Assert
            Assert.True(result.IsShort);  // Curt=true
            Assert.True(result.IsPalindrome); // Palindrome=true

        }
        [Fact]
        public void NameAnalyserTest1()
        {
            // Arrange
            string name = "Paula";
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            var result = personaHelper.NameAnalyser(name);

            // Assert
            Assert.False(result.IsShort);  // Curt=false
            Assert.False(result.IsPalindrome); // Palindrome=false

        }
        [Fact]
        public void NameAnalyserTest2()
        {
            // Arrange
            string name = "Adrian";
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            var result = personaHelper.NameAnalyser(name);

            // Assert
            Assert.False(result.IsShort);  // Curt=false
            Assert.False(result.IsPalindrome); // Palindrome=false

        }
        [Fact]
        public void VerifyColourTest()
        {
            //Arrange
            string colour = "Blau";
            var personaHelper = new PersonaHelper(); //Istanciar!!!
            // Act 
            var result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(0, result); //Calmant
        }
        [Fact]
        public void VerifyColourTest1()
        {
            //Arrange
            string colour = "Verd";
            var personaHelper = new PersonaHelper(); //Istanciar!!!
            // Act 
            var result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(0, result); //Calmant
        }
        [Fact]
        public void VerifyColourTest2()
        {
            //Arrange
            string colour = "Vermell";
            var personaHelper = new PersonaHelper(); //Istanciar!!!
            // Act 
            var result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(1, result); //Exclusiu
        }
        [Fact]
        public void VerifyColourTest3()
        {
            //Arrange
            string colour = "";
            var personaHelper = new PersonaHelper(); //Istanciar!!!
            // Act 
            var result = personaHelper.VerifyColour(colour);
            //Assert
            Assert.Equal(-1, result); //Invàlid
        }
        public void PersonalityTest()
        {
            // Arrange
            string timeOfDay = "matí";
            var personaHelper = new PersonaHelper();

            // Act
            var result = personaHelper.PersonalityTest(timeOfDay); //Istanciar!!!

            // Assert
            Assert.Equal(0, result); //Matinal
        }

        [Fact]
        public void PersonalityTest1()
        {
            // Arrange
            string timeOfDay = "nit";
            var personaHelper = new PersonaHelper(); //Istanciar!!!

            // Act
            var result = personaHelper.PersonalityTest(timeOfDay);

            // Assert
            Assert.Equal(1, result); //Nocturnal
        }

        [Fact]
        public void PersonalityTest2()
        {
            // Arrange
            string timeOfDay = "tarda";
            var personaHelper = new PersonaHelper(); //Istanciar!!!

            // Act
            var result = personaHelper.PersonalityTest(timeOfDay);

            // Assert
            Assert.Equal(2, result); //Imprevista

        }
    }
}