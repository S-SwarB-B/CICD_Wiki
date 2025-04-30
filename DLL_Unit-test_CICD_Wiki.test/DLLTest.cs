using DDL_Unit_test_CICD_Wiki;

namespace DLL_Unit_test_CICD_Wiki.test
{
    public class DLLTest
    {
        [Fact]
        public void TestSort()
        {
            ProgramDLL program = new ProgramDLL(); 
            int[] mass = new int[5] { 1, 5, 2, 5, 1 };           //Массив
            int[] expected = new int[5] {1, 1, 2, 5, 5};         //Ожидаемое
            int[] actual = program.SortArray(mass,1);            //Актуальное

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestFilter_one()
        {
            ProgramDLL program = new ProgramDLL();               
            int[] mass = new int[5] { 1, 5, 2, 5, 1 };           //Массив
            int[] expected = new int[1] { 2 };                   //Ожидаемое
            int[] actual = program.FiltrMass(mass, 1);           //Актуальное

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestFilter_two()
        {
            ProgramDLL program = new ProgramDLL();
            int[] mass = new int[5] { 1, 5, 2, 5, 1 };          //Массив
            int[] expected = new int[3] { 5, 2, 5 };            //Ожидаемое
            int[] actual = program.FiltrMass(mass, 1, 6);       //Актуальное

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestPoisk()
        {
            ProgramDLL program = new ProgramDLL();
            int[] mass = new int[5] { 1, 5, 2, 5, 1 };         //Массив
            int expected = 2;                                  //Ожидаемое
            int actual = program.PoiskMass(mass, 1, 2);        //Актуальное

            Assert.Equal(expected, actual);
        }
    }
}
