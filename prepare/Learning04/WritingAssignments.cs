using System;

public class WritingAssignments : Assignment
{
    private string _title;

    public WritingAssignments(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }



}