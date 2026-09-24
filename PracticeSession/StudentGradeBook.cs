using System.Runtime.CompilerServices;

public record Student(string Name, double Score);

public class StudentGradeBook
{
    private List<Student> _students = [];

    public void AddStudent(string name, double score)
    {
        var student = new Student(name, score);
        _students.Add(student);

    }

    public double GetAverageScore()
    {
        if(_students.Count == 0){
            return 0;
        }
        return _students.Average(s => s.Score);
        
    }
    public List<string> GetHonorRoll(double threshold)
    {
        return _students
            .Where(s => s.Score >= threshold)
            .OrderByDescending(s => s.Score)
            .Select(s => s.Name)
            .ToList();
    }
}