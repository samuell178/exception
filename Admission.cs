public class Admission
{
    public void CheckAge(int age)
    {
        if (age < 16)
        {
            throw new Exception("Admission is for students above 16");
        }
    }
}