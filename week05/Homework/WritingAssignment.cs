using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string textbookSection, string problems, string title)
        : base(studentName, topic)  //call the Assignment constructor
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()} - \" {_title}\"";
    }
}