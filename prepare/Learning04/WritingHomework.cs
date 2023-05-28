using System;

class WritingHomework: Homework
{
    private string _literature = "";

    public WritingHomework(string studentName, string topic, string literature)
        : base(studentName, topic)
    {
        _literature = literature;
    }
    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_literature} by {studentName}";
    }

}