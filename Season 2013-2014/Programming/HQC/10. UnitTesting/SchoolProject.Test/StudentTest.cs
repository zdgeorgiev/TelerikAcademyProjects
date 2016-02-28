using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StudentTest
{
    [TestMethod]
    public void CheckStudentName()
    {
        Student st = new Student("Pesho", 20000);
        Assert.AreEqual(st.Name, "Pesho");
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CheckInvalidName()
    {
        Student st = new Student(string.Empty, 20000);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void CheckNullName()
    {
        Student st = new Student(null, 20000);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void CheckInvalidUniqueNumberHigh()
    {
        Student st = new Student("Pesho", 1000000);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void CheckInvalidUniqueNumberLow()
    {
        Student st = new Student("Pesho", 602);
    }

    [TestMethod]
    public void CheckGetForUniqueNumber()
    {
        Student st = new Student("Pesho", 20000);
        Assert.AreEqual(st.UniqueNumber, 20000);
    }

    [TestMethod]
    public void CheckToStringMethod()
    {
        Student st = new Student("Pesho", 20000);
        Assert.AreEqual(st.ToString(), "Student name - Pesho, UniqueNumber - 20000");
    }
}