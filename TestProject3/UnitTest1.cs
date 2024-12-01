using ExerciseFive;
using Xunit;

namespace TestProject3
{
    public class Exercici5
    {
       
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
            int age = 18;
            var personaHelper = new PersonaHelper(); // Instanciar!!!

            // Act
            int result = personaHelper.ClassifyAge(age);

            // Assert
            Assert.Equal(1, result); // Adulta
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
            Assert.True(result); // true
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
    }
}
